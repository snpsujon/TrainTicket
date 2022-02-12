using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.ViewModels
{
    public class AvlTickInsVM
    {
        public String TrainName { get; set; }
        public DateTime JourneyTime { get; set; }
        public int TotalSit { get; set; }
        public string SitClass { get; set; }
        public string FromStation { get; set; }
        public string ToStation { get; set; }
        
    }
}
