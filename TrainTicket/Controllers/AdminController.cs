using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTicket.Data;
using TrainTicket.Models;

namespace TrainTicket.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _context;
        public AdminController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Users()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
                
            }
            if(HttpContext.Session.GetString("UserType") == "Admin")
            {
                var TotalUsers = _context.userInformations.Count();
                ViewBag.TotalUsers = TotalUsers;
                var allusers = _context.userInformations.ToList();
                return View(allusers);
            }
            return RedirectToAction("NotFound", "Home");
        }


        //Get Edit User by Admin
        public IActionResult EditUser(int id)
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
                
            }
            if (HttpContext.Session.GetString("UserType") == "Admin")
            {
                loadDDL();
                UserInformation user = _context.userInformations.Find(id);
                //var user = _context.userInformations.Where(x => x.UserID == id);

                return View(user);
            }
            return RedirectToAction("NotFound", "Home");
            
        }
        [HttpPost]
        public IActionResult EditUser(UserInformation userInformations)
        {
            _context.Entry(userInformations).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Users");
        }


        private void loadDDL()
        {

            List<UserType> userTypes = new List<UserType>();
            userTypes = _context.userTypes.ToList();
            

            ViewBag.UserTypes = userTypes;
            

        }








    }
}
