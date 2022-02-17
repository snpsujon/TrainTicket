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
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            UserInformation userinformation = _context.userInformations.Where(x => x.UserID == userid).FirstOrDefault();

            //For DashBoard Graph
            var TotalTicket = _context.ticketInformations.Sum(p => p.TotalSit);
            var sellinformation = _context.bookingInformations.Where(x => x.SellerID == userid).ToList();
            var totalsell = sellinformation.Sum(p => p.TicketQuantity);
            var buyinformation = _context.bookingInformations.Where(x => x.BuyerID == userid).ToList();
            var toalbuy = buyinformation.Sum(p => p.TicketQuantity);
            if(TotalTicket != 0)
            {
                int sellgrph = Convert.ToInt32((Convert.ToDecimal(totalsell)/Convert.ToDecimal(TotalTicket))*100);
                ViewBag.sellgrph = sellgrph;
            }
            
            if(TotalTicket != 0)
            {
                int buygrph = Convert.ToInt32((Convert.ToDecimal(toalbuy) / Convert.ToDecimal(TotalTicket)) * 100);
                ViewBag.buygrph = buygrph;
            }
            

            
            
            //End DashBoard Graph


            return View(userinformation);
        }

        public IActionResult ProfilePicture()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
            }
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

            if (userinformation.ProfilePicture != null)
            {
                //for delete picture from database file path search
                var propic = userinformation.ProfilePicture;
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images");
                var filepath = Path.Combine(path, propic);
                FileInfo picture = new FileInfo(filepath);
                if (model.Deletepro == true)
                {
                    picture.Delete();        //If you want to delete picture from upload folder
                    userinformation.ProfilePicture = null;
                    userinformation.UserFullName = model.UserFullName;
                    userinformation.UserEmail = model.UserEmail;
                    userinformation.UserPhoneNumber = model.UserPhoneNumber;
                    userinformation.UserPassword = model.UserPassword;
                }
                else
                {
                    if (model.ProfileImage != null)
                    {
                        picture.Delete();
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


                }
               
            }
            else
            {
                if (model.ProfileImage != null)
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


            }

            
            
            _context.Update(userinformation);
            _context.SaveChanges();

            //HttpContext.Session.SetString("UserPro", uniqueFileName);
            return RedirectToAction("UserProfile");
            
        }




        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("NotFound", "Home");
            }
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
