using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTicket.Data;
using TrainTicket.Models;

namespace TrainTicket.Controllers
{
    public class UsertypeController : Controller
    {
        private readonly DataContext _context;


        public UsertypeController(DataContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var usertype = _context.userTypes.ToList();
            return View(usertype);
        }

        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserType userTypes)
        {
            _context.Add(userTypes);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }











    }
}
