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
    public class TrainsController : Controller
    {
        private readonly DataContext _context;


        public TrainsController(DataContext context)
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
                var totaltrain = _context.trains.Count();
                ViewBag.totaltrain = totaltrain;
                var trains = _context.trains.ToList();
                return View(trains);
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
        public IActionResult Create(Train trains)
        {
            _context.Add(trains);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
