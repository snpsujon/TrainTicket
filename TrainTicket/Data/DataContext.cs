using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTicket.Models;

namespace TrainTicket.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<TicketInformation> ticketInformations { get; set; }
        public DbSet<Station> stations { get; set; }
        public DbSet<SellerInformation> sellerInformations { get; set; }
        public DbSet<BuyerInformation> buyerInformations { get; set; }
        public DbSet<BookingInformation> bookingInformations { get; set; }
    }
}
