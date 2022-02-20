using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class BookingController : Controller
    {

        private readonly DataContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public BookingController(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }


        //Get || Ticket Booking by buyer
        public IActionResult Booking(int id)
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            loadDDL();
            var ticket = _context.ticketInformations.Find(id);
            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            UserInformation buyer = _context.userInformations.Where(x => x.UserID == userid).FirstOrDefault();
            var seller = _context.userInformations.Where(x => x.UserID == ticket.SellerID).FirstOrDefault();
            var tickets = ticket.TotalSit;
            

            BookingVM booking = new BookingVM
            {
                FromStation = ticket.FStarionName,
                ToStation = ticket.TStationName,
                TrainName = ticket.TrainName,
                JourneyTime = ticket.JourneyTime,
                TotalSit = ticket.TotalSit,
                SitClass = ticket.SitClass,
                PerTicketPrice = ticket.PerTicketPrice,
                TicketID = ticket.TicketID,

                SellerName = seller.UserFullName,
                SellerPhone = seller.UserPhoneNumber,
                SellerEmail = seller.UserEmail,
                SellerID = seller.UserID,

                BuyerName = buyer.UserFullName,
                BuyerEmail = buyer.UserEmail,
                BuyerPhone = buyer.UserPhoneNumber,
                BuyerID = buyer.UserID,





            };


            return View(booking);
            //return View();
        }


        //Post || Ticket Booking by buyer
        [HttpPost]
        public IActionResult Booking(BookingVM booking)
        {

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[3];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var OrderNumber = new String(stringChars);

            var rand = new Random();
            var Invoice = rand.Next(100000, 1000000);

            UserInformation buyer = _context.userInformations.Find(booking.BuyerID);
            UserInformation seller = _context.userInformations.Find(booking.SellerID);
            TicketInformation ticket = _context.ticketInformations.Find(booking.TicketID);

            ticket.TotalSit = booking.TotalSit;

            BookingInformation booked = new BookingInformation
            {
                BuyerID = booking.BuyerID,
                SellerID = booking.SellerID,
                TicketID = booking.TicketID,
                TicketQuantity = booking.TicketQuantity,
                TicketTotalPrice = booking.TicketTotalPrice,
                BookedTime = booking.BookedTime,
                PaymentType = booking.PaymentType,
                PaymentConfirmation = booking.PaymentConfirmation,
                InvoiceNumber = Invoice,
                OrderID = OrderNumber,
                BookingStatus = "Pending",
            };

            _context.Update(ticket);
            _context.Add(booked);
            _context.SaveChanges();



            return RedirectToAction("BookingTickets", "Booking");
        }




        //GET || Sell All Booked By User
        public IActionResult BookingTickets()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            var bookings = (from a in _context.bookingInformations
                          join b in _context.userInformations.Where(x=> x.UserID == userid)
                          on a.BuyerID equals b.UserID
                          join c in _context.userInformations
                          on a.SellerID equals c.UserID
                          join d in _context.ticketInformations
                          on a.TicketID equals d.TicketID

                          select new BookingVM
                          {
                              BookingID = a.BookingID,
                              FromStation = d.FStarionName,
                              ToStation = d.TStationName,
                              JourneyTime = d.JourneyTime,
                              TicketQuantity = a.TicketQuantity,
                              SellerName = c.UserFullName,
                              TrainName = d.TrainName,
                              
                          }).OrderByDescending(p => p.BookingID);

            return View(bookings);
        }



        //GET || See all Booking Request to the Seller
        public IActionResult BookingRequests()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Login", "Home");
            }


            if (HttpContext.Session.GetString("UserType") == "Admin" || HttpContext.Session.GetString("UserType") == "Seller")
            {
                var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                var bookings = (from a in _context.bookingInformations
                                join b in _context.userInformations
                                on a.BuyerID equals b.UserID
                                join c in _context.userInformations.Where(x => x.UserID == userid)
                                on a.SellerID equals c.UserID
                                join d in _context.ticketInformations
                                on a.TicketID equals d.TicketID

                                select new BookingVM
                                {
                                    BookedTime = a.BookedTime,
                                    BookingID = a.BookingID,
                                    FromStation = d.FStarionName,
                                    ToStation = d.TStationName,
                                    JourneyTime = d.JourneyTime,
                                    TicketQuantity = a.TicketQuantity,
                                    BuyerName = b.UserFullName,
                                    TrainName = d.TrainName,
                                    BookingStatus = a.BookingStatus,

                                }).OrderByDescending(p => p.BookingID);

                return View(bookings);
            }
            return RedirectToAction("NotFound", "Home");
        }


        public IActionResult Details(int id)
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            var valid = _context.bookingInformations.Where(x => x.BookingID == id).FirstOrDefault().BuyerID;
            if (valid == userid)
            {
                var bookings = (from a in _context.bookingInformations.Where(x => x.BookingID == id)
                                join b in _context.userInformations
                                on a.BuyerID equals b.UserID
                                join c in _context.userInformations
                                on a.SellerID equals c.UserID
                                join d in _context.ticketInformations
                                on a.TicketID equals d.TicketID

                                select new BookingVM
                                {
                                    SellerName = c.UserFullName,
                                    SellerPhone = c.UserPhoneNumber,
                                    SellerEmail = c.UserEmail,


                                    BuyerName = b.UserFullName,
                                    BuyerPhone = b.UserPhoneNumber,
                                    BuyerEmail = b.UserEmail,

                                    TicketQuantity = a.TicketQuantity,
                                    TicketTotalPrice = a.TicketTotalPrice,
                                    PaymentType = a.PaymentType,
                                    PaymentConfirmation = a.PaymentConfirmation,
                                    BookedTime = a.BookedTime,
                                    OrderID = a.OrderID,
                                    InvoiceNumber = a.InvoiceNumber,
                                    BookingStatus = a.BookingStatus,
                                    BookingFile = a.BookingAttachment,


                                    TrainName = d.TrainName,
                                    JourneyTime = d.JourneyTime,
                                    PerTicketPrice = d.PerTicketPrice,
                                }).FirstOrDefault();

                return View(bookings);
            }
            else
            {
                return RedirectToAction("NotFound", "Home");
            }
            


        }


        public IActionResult AllBooking()
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            if (HttpContext.Session.GetString("UserType") == "Admin")
            {
                var userid = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
                var bookings = (from a in _context.bookingInformations
                                join b in _context.userInformations
                                on a.BuyerID equals b.UserID
                                join c in _context.userInformations
                                on a.SellerID equals c.UserID
                                join d in _context.ticketInformations
                                on a.TicketID equals d.TicketID

                                select new BookingVM
                                {
                                    BookingID = a.BookingID,
                                    FromStation = d.FStarionName,
                                    ToStation = d.TStationName,
                                    JourneyTime = d.JourneyTime,
                                    TicketQuantity = a.TicketQuantity,
                                    BuyerName = b.UserFullName,
                                    TrainName = d.TrainName,
                                    SellerName = c.UserFullName,
                                    BookingStatus = a.BookingStatus,

                                }).OrderByDescending(p => p.BookingID);

                return View(bookings);
            }
            else
            {
                return RedirectToAction("NotFound", "Home");
            }

                
        }


        public IActionResult UpdateStatus(int id)
        {
            if (HttpContext.Session.GetString("Email") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            if (HttpContext.Session.GetString("UserType") == "Admin" || HttpContext.Session.GetString("UserType") == "Seller")
            {
                var booking = _context.bookingInformations.Where(x => x.BookingID == id).FirstOrDefault();
                BookingVM booked = new BookingVM
                {
                    BookingID = booking.BookingID,

                };

                return View(booked);
            }
            else
            {
                return RedirectToAction("NotFound", "Home");
            }
                
        }
        [HttpPost]
        public IActionResult UpdateStatus(BookingVM model)
        {
            string uniqueFileName = UploadedFile(model);
            //var bookingid = Convert.ToInt32(model.BookingID);
            BookingInformation booking = _context.bookingInformations.Where(x => x.BookingID == model.BookingID).FirstOrDefault();

            booking.BookingAttachment = uniqueFileName;
            booking.BookingStatus = model.BookingStatus;

            _context.Update(booking);
            _context.SaveChanges();


            return RedirectToAction("Index","Home");
        }




        private string UploadedFile(BookingVM model)
        {
            string uniqueFileName = null;

            if (model.BookingAttachment != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "BookingAttachment");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.BookingAttachment.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.BookingAttachment.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }



        private void loadDDL()
        {

            List<Station> stations = new List<Station>();
            stations = _context.stations.ToList();
            List<Train> trains = new List<Train>();
            trains = _context.trains.ToList();

            ViewBag.TrainName = trains;
            ViewBag.StationName = stations;

        }

        private void random()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[3];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            var rand = new Random();
            var uid = rand.Next(100000, 1000000);

            ViewBag.uid1 = finalString;
            ViewBag.uid = uid;
        }

    }
}
