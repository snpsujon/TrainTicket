using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.Models
{
    public class Station
    {
        [Key]
        public int StationID { get; set; }
        public string Stations { get; set; }

    }
}
