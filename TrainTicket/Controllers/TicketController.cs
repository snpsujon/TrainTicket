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

            if (HttpContext.Session.GetString("UserType") == "Admin" || HttpContext.Session.GetString("UserType") == "Seller")
            {
                var AllTicInf = _context.ticketInformations.OrderByDescending(p => p.TicketID).ToList();
                var avlTickts = _context.ticketInformations.Where(x => x.TotalSit != 0 && (x.JourneyTime > DateTime.Now || x.JourneyTime == DateTime.Now)).OrderByDescending(p=>p.TicketID).ToList();
                ViewData["avlTickts"] = avlTickts;
                var expTickts = _context.ticketInformations.Where(x => x.TotalSit == 0 || x.JourneyTime < DateTime.Now).OrderByDescending(p => p.TicketID).ToList();
                ViewData["expTickts"] = expTickts;
                

                return View(AllTicInf);
            }
            return RedirectToAction("NotFound", "Home");




    }

        public IActionResult Create()
        {

            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
            }
            if (HttpContext.Session.GetString("UserType") == "Admin" || HttpContext.Session.GetString("UserType") == "Seller")
            {
                loadDDL();

                return View();
            }
            return RedirectToAction("NotFound", "Home");
        }
        [HttpPost]
        public IActionResult Create(TicketInformation ticketInformations)
        {
            if(_context.ticketInformations.Count() != 0)
            {
                var totaltickets = _context.ticketInformations.OrderByDescending(p=>p.TicketID).FirstOrDefault().TotalTicketsAllTime;
                var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                TicketInformation ticket = new TicketInformation
                {
                    TrainName = ticketInformations.TrainName,
                    JourneyTime = ticketInformations.JourneyTime,
                    PerTicketPrice = ticketInformations.PerTicketPrice,
                    TotalSit = ticketInformations.TotalSit,
                    FStarionName = ticketInformations.FStarionName,
                    TStationName = ticketInformations.TStationName,
                    SitClass = ticketInformations.SitClass,
                    SellerID = userid,
                    TotalTicketsAllTime = (ticketInformations.TotalSit + totaltickets)
                };
                _context.Add(ticket);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                var totaltickets = 0;
                var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                TicketInformation ticket = new TicketInformation
                {
                    TrainName = ticketInformations.TrainName,
                    JourneyTime = ticketInformations.JourneyTime,
                    PerTicketPrice = ticketInformations.PerTicketPrice,
                    TotalSit = ticketInformations.TotalSit,
                    FStarionName = ticketInformations.FStarionName,
                    TStationName = ticketInformations.TStationName,
                    SitClass = ticketInformations.SitClass,
                    SellerID = userid,
                    TotalTicketsAllTime = (ticketInformations.TotalSit + totaltickets)
                };
                _context.Add(ticket);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View();
            
            
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
