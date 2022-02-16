using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTicket.Data;
using TrainTicket.Models;
using TrainTicket.ViewModels;

namespace TrainTicket.Controllers
{
    public class TicketController : Controller
    {
        private readonly DataContext _context;


        public TicketController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index(DateTime SearchbyDate)
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
            }
            var TicInf = _context.ticketInformations.ToList();
            var TotalTicket = _context.ticketInformations.Sum(p => p.TotalSit);
            ViewBag.TotalTicket = TotalTicket;
            var msg = "Total Avl Ticket";
            ViewBag.msg = msg;
            var date = SearchbyDate;
            
            if (date.ToString() != "1/1/0001 12:00:00 AM")
            {
                var searchdate = _context.ticketInformations.Where(x => x.JourneyTime > date || x.JourneyTime == date).ToList();
                if (searchdate.Count != 0)
                {
                    var dates = SearchbyDate.ToString("dd MMMM yyyy");
                    ViewBag.msg = "Total Avl Tickets On " + dates;
                    TotalTicket = searchdate.Sum(p => p.TotalSit);
                    ViewBag.TotalTicket = TotalTicket;
                    return View(searchdate);
                }
                else
                {
                    ViewBag.TotalTicket = "No Avl Ticket";
                    return View(TicInf);
                }
            }

            return View(TicInf);



        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
            }
            loadDDL();

            return View();
        }
        [HttpPost]
        public IActionResult Create(TicketInformation ticketInformations)
        {
            _context.Add(ticketInformations);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }












        private void loadDDL()
        {
           
                List<Station> stations = new List<Station>();
                stations = _context.stations.ToList();
                List<Train> trains = new List<Train>();
                trains = _context.trains.ToList();

                ViewBag.TrainName = trains;
                ViewBag.StationName = stations;
           
        }
        
        


     }
}
