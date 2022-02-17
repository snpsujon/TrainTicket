using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.ViewModels
{
    public class BookingVM
    {
        public string BuyerName { get; set; }
        public int BuyerID { get; set; }
        public string BuyerPhone { get; set; }
        public string BuyerEmail { get; set; }




        public string SellerName { get; set; }
        public int SellerID { get; set; }
        public string SellerPhone { get; set; }
        public string SellerEmail { get; set; }



        public string FromStation { get; set; }
        public string ToStation { get; set; }
        public string TrainName { get; set; }
        public string SitClass { get; set; }
        public string PerTicketPrice { get; set; }
        public int TotalSit { get; set; }
        public int TicketID { get; set; }
        public DateTime JourneyTime { get; set; }






        public int TicketQuantity { get; set; }
        public int TicketTotalPrice { get; set; }
        public DateTime BookedTime { get; set; }
        public string PaymentType { get; set; }
        public string PaymentConfirmation { get; set; }

    }
}
