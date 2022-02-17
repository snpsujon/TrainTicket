using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTicket.Data;
using TrainTicket.Models;

namespace TrainTicket.Controllers
{
    public class StationsController : Controller
    {
        private readonly DataContext _context;


        public StationsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
                
            }
            if (HttpContext.Session.GetString("UserType") == "Admin" || HttpContext.Session.GetString("UserType") == "Seller")
            {
                var totalStation = _context.stations.Count();
                ViewBag.totalStation = totalStation;
                var stations = _context.stations.ToList();
                return View(stations);
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
                return View();
            }
            return RedirectToAction("NotFound", "Home");
        }
        [HttpPost]
        public IActionResult Create(Station station)
        {
            _context.Add(station);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }









    }
}
