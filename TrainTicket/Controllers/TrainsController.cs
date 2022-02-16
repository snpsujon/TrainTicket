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
            var totaltrain = _context.trains.Count();
            ViewBag.totaltrain = totaltrain;
            var trains = _context.trains.ToList();
            return View(trains);
        }
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
            }
            return View();
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
