using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.Models
{
    public class BookingInformation
    {
        [Key]
        public int BookingID{ get; set; }
        public int BuyerID { get; set; }
        public int SellerID { get; set; }
        public int TicketID { get; set; }
        public int TicketQuantity { get; set; }
        public int TicketTotalPrice { get; set; }
        public DateTime BookedTime { get; set; }
        public string PaymentType { get; set; }
        public string PaymentConfirmation { get; set; }
        
        
    }
}
