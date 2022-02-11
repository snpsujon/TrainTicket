using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.Models
{
    public class SellerInformation
    {
        [Key]
        public int SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerPhone { get; set; }

        [EmailAddress]
        public string SellerEmail { get; set; }

        [Compare("SellerCPassword", ErrorMessage = "Password Doesn't Match")]
        public string SellerPassword { get; set; }

        public int BuyerID { get; set; }

        [NotMapped]
        public string SellerCPassword { get; set; }
    }
}
