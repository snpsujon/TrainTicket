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
            var trains = _context.trains.ToList();
            return View(trains);
        }
        public IActionResult Create()
        {
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
