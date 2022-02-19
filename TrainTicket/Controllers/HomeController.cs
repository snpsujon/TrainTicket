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


            //if (HttpContext.Session.GetString("Email") == null)
            //{
            //    return RedirectToAction("Login", "Home");
            //}   

    public IActionResult Index(DateTime SearchbyDate)
        {
            ViewBag.UserEmail = HttpContext.Session.GetString("Email"); 
            ViewBag.UserType = HttpContext.Session.GetString("UserType"); 


            var TicInf = _context.ticketInformations.Where(x=>x.TotalSit != 0).ToList();
            var TotalTicket = _context.ticketInformations.Sum(p => p.TotalSit);
            ViewBag.TotalTicket = TotalTicket;
            var msg = "Total Avl Ticket";
            ViewBag.msg = msg;
            var date = SearchbyDate;

            
            if (date.ToString() != "1/1/0001 12:00:00 AM")
            {
                var searchdate = _context.ticketInformations.Where(x => (x.JourneyTime > date && x.TotalSit != 0) || (x.JourneyTime == date && x.TotalSit != 0)).ToList();
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
            //if (HttpContext.Session.GetString("Email") == null)
            //{
            //    return RedirectToAction("Login", "Home");
            //}
            loadDDL();
            return View();
        }

        public JsonResult CheckUsernameAvailability(string userdata)
        {
            System.Threading.Thread.Sleep(200);
            var SeachData = _context.userInformations.Where(x => x.UserEmail == userdata).SingleOrDefault();
            if (SeachData != null)
            {
                return Json(1);
            }
            else
            {
                return Json(0);
            }

        }


        [HttpPost]
        public IActionResult Create(UserInformation userInformations)
        {
            
            var usertype = "Buyer";
            UserInformation users = new UserInformation
            {
                UserFullName = userInformations.UserFullName,
                UserPhoneNumber = userInformations.UserPhoneNumber,
                UserEmail = userInformations.UserEmail,
                UserPassword = userInformations.UserPassword,
                UserType = usertype,
                IsActive = true,
            };
            
                _context.Add(users);
                _context.SaveChanges();
                return RedirectToAction(nameof(Login));
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
                HttpContext.Session.SetString("UserID", adm.UserID.ToString());
                HttpContext.Session.SetString("UserName", adm.UserFullName.ToString());
                HttpContext.Session.SetString("Email", adm.UserEmail);
                HttpContext.Session.SetString("UserType", adm.UserType);
                if(adm.ProfilePicture != null)
                {
                    HttpContext.Session.SetString("UserPro", adm.ProfilePicture);
                }
                

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }


        }



        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            
            return RedirectToAction(nameof(Index));
        }

        public IActionResult NotFound()
        {
            

            return View();
        }











        private void loadDDL()
        {

            List<UserType> userTypes = new List<UserType>();
            userTypes = _context.userTypes.ToList();
            

            
            ViewBag.StationName = userTypes;

        }




    }
}
