using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TrainTicket.Data;
using TrainTicket.Models;
using TrainTicket.ViewModels;

namespace TrainTicket.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public UserController(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult UserProfile()
        {
            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            UserInformation userinformation = _context.userInformations.Where(x => x.UserID == userid).FirstOrDefault();

            return View(userinformation);
        }

        public IActionResult ProfilePicture()
        {
            int userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            UserInformation user =_context.userInformations.Find(userid);
            UserInformationsVM uservm = new UserInformationsVM
            {
                UserID = user.UserID,
                UserFullName = user.UserFullName,
                UserEmail = user.UserEmail,
                UserPhoneNumber = user.UserPhoneNumber,
                UserPassword = user.UserPassword,
                UserType = user.UserType,
                ProfileImage = user.ProfileImage,
            };
            return View(uservm);
        }
        [HttpPost]
        public async Task<IActionResult> ProfilePicture (UserInformationsVM model)
        {
            string uniqueFileName = UploadedFile(model);
            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            UserInformation userinformation = _context.userInformations.Where(x => x.UserID == userid).FirstOrDefault();


            
            if(model.ProfileImage != null)
            {
                userinformation.ProfilePicture = uniqueFileName;
                userinformation.UserFullName = model.UserFullName;
                userinformation.UserEmail = model.UserEmail;
                userinformation.UserPhoneNumber = model.UserPhoneNumber;
                userinformation.UserPassword = model.UserPassword;

            }
            else
            {
                
                userinformation.UserFullName = model.UserFullName;
                userinformation.UserEmail = model.UserEmail;
                userinformation.UserPhoneNumber = model.UserPhoneNumber;
                userinformation.UserPassword = model.UserPassword;
            }
            _context.Update(userinformation);
            _context.SaveChanges();
            return RedirectToAction("UserProfile");
            
        }




        public IActionResult Index()
        {
            ViewBag.UserID = HttpContext.Session.GetString("UserID");
            return View();
        }





        private string UploadedFile(UserInformationsVM model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }



    }
}
