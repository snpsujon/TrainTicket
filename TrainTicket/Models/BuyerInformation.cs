using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.Models
{
    public class BuyerInformation
    {
        [Key]
        public int BuyerID { get; set; }
        public string BuyerName { get; set; }
        public string BuyerPhone { get; set; }

        [EmailAddress]
        public string BuyerEmail { get; set; }

        [Compare("BuyerCPassword", ErrorMessage = "Password Doesn't Match")]
        public string BuyerPassword { get; set; }

        public int SellerID{ get; set; }

        [NotMapped]
        public string BuyerCPassword { get; set; }
    }
}
