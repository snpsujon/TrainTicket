using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.Models
{
    public class Train
    {
        [Key]
        public int TrainID { get; set; }
        public string TrainName { get; set; }
    }
}
