using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public BookingController(DataContext context)
        {
            _context = context;
        }

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

        [HttpPost]
        public IActionResult Booking(BookingVM booking)
        {
            
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
            };

            _context.Update(ticket);
            _context.Add(booked);
            _context.SaveChanges();



            return RedirectToAction("Index", "Home");
        }





        public IActionResult Index()
        {
            return View();
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
    }
}
