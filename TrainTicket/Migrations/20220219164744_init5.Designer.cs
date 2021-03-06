// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainTicket.Data;

namespace TrainTicket.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220219164744_init5")]
    partial class init5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TrainTicket.Models.BookingInformation", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BookedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingAttachment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BuyerID")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceNumber")
                        .HasColumnType("int");

                    b.Property<string>("OrderID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentConfirmation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.Property<int>("TicketID")
                        .HasColumnType("int");

                    b.Property<int>("TicketQuantity")
                        .HasColumnType("int");

                    b.Property<int>("TicketTotalPrice")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.ToTable("bookingInformations");
                });

            modelBuilder.Entity("TrainTicket.Models.BuyerInformation", b =>
                {
                    b.Property<int>("BuyerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BuyerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.HasKey("BuyerID");

                    b.ToTable("buyerInformations");
                });

            modelBuilder.Entity("TrainTicket.Models.SellerInformation", b =>
                {
                    b.Property<int>("SellerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BuyerID")
                        .HasColumnType("int");

                    b.Property<string>("SellerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellerID");

                    b.ToTable("sellerInformations");
                });

            modelBuilder.Entity("TrainTicket.Models.Station", b =>
                {
                    b.Property<int>("StationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Stations")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationID");

                    b.ToTable("stations");
                });

            modelBuilder.Entity("TrainTicket.Models.TicketInformation", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FStarionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JourneyTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PerTicketPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.Property<string>("SitClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TStationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalSit")
                        .HasColumnType("int");

                    b.Property<int>("TotalTicketsAllTime")
                        .HasColumnType("int");

                    b.Property<string>("TrainName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketID");

                    b.ToTable("ticketInformations");
                });

            modelBuilder.Entity("TrainTicket.Models.Train", b =>
                {
                    b.Property<int>("TrainID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TrainName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainID");

                    b.ToTable("trains");
                });

            modelBuilder.Entity("TrainTicket.Models.UserInformation", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("userInformations");
                });

            modelBuilder.Entity("TrainTicket.Models.UserType", b =>
                {
                    b.Property<int>("UserTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserTypeN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTypeID");

                    b.ToTable("userTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
