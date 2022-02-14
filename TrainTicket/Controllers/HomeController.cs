using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrainTicket.Data;
using TrainTicket.Models;

namespace TrainTicket.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }


        public IActionResult Index(DateTime SearchbyDate)
        {
            ViewBag.user = HttpContext.Session.GetString("UserName"); 

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
            loadDDL();
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserInformation userInformations)
        {
            var useremail = userInformations.UserEmail;
            var dbem = _context.userInformations.FirstOrDefault(x => x.UserEmail == useremail).UserEmail;
            if (useremail == dbem)
            {
                return RedirectToAction(nameof(Index));
            }

            _context.Add(userInformations);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
           
        }




        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string UserEmail, string UserPassword)
        {
            var adm = _context.userInformations.FirstOrDefault(x => x.UserEmail == UserEmail && x.UserPassword == UserPassword);
            ViewBag.pp = adm;
            if (adm != null)
            {
                
                HttpContext.Session.SetString("UserName", adm.UserFullName.ToString());
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }


        }















        private void loadDDL()
        {

            List<UserType> userTypes = new List<UserType>();
            userTypes = _context.userTypes.ToList();
            

            
            ViewBag.StationName = userTypes;

        }





        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
