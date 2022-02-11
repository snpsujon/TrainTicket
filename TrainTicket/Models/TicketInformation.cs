using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.Models
{
    public class TicketInformation
    {
        [Key]
        public int TicketID { get; set; }
        public String TrainName { get; set; }
        public DateTime JourneyTime{ get; set; }
        public int TotalSit{ get; set; }
        public string SitClass { get; set; }
        public int StationID{ get; set; }
        public int SellerID { get; set; }


        [NotMapped]
        public string StationName{ get; set; }
        [NotMapped]
        public string SellerName { get; set; }
    }
}
