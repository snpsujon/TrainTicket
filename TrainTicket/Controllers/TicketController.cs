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
        public IActionResult Index()
        {
            var TicInf = from a in _context.ticketInformations
                         join b in _context.stations
                         on a.StationID equals b.StationID

                         select new AvlTickInsVM
                         {
                             TrainName = a.TrainName,
                             JourneyTime = a.JourneyTime,
                             TotalSit = a.TotalSit,
                             SitClass = a.SitClass,
                             StationName = b.Stations,
                         };
            return View(TicInf);
        }

        public IActionResult Create()
        {
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
            try
            {
                List<Station> stations = new List<Station>();
                stations = _context.stations.ToList();



                ViewBag.StationName = stations;
            }
            catch (Exception ex)
            {

                
            }
        }


     }
}
