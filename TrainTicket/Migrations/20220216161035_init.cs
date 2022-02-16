using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTicket.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookingInformations",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerID = table.Column<int>(type: "int", nullable: false),
                    SellerID = table.Column<int>(type: "int", nullable: false),
                    BookedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentConfirmation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingInformations", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "buyerInformations",
                columns: table => new
                {
                    BuyerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buyerInformations", x => x.BuyerID);
                });

            migrationBuilder.CreateTable(
                name: "sellerInformations",
                columns: table => new
                {
                    SellerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sellerInformations", x => x.SellerID);
                });

            migrationBuilder.CreateTable(
                name: "stations",
                columns: table => new
                {
                    StationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stations = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stations", x => x.StationID);
                });

            migrationBuilder.CreateTable(
                name: "ticketInformations",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JourneyTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalSit = table.Column<int>(type: "int", nullable: false),
                    SitClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FStarionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TStationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SellerID = table.Column<int>(type: "int", nullable: false),
                    PerTicketPrice = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticketInformations", x => x.TicketID);
                });

            migrationBuilder.CreateTable(
                name: "trains",
                columns: table => new
                {
                    TrainID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trains", x => x.TrainID);
                });

            migrationBuilder.CreateTable(
                name: "userInformations",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInformations", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "userTypes",
                columns: table => new
                {
                    UserTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTypes", x => x.UserTypeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingInformations");

            migrationBuilder.DropTable(
                name: "buyerInformations");

            migrationBuilder.DropTable(
                name: "sellerInformations");

            migrationBuilder.DropTable(
                name: "stations");

            migrationBuilder.DropTable(
                name: "ticketInformations");

            migrationBuilder.DropTable(
                name: "trains");

            migrationBuilder.DropTable(
                name: "userInformations");

            migrationBuilder.DropTable(
                name: "userTypes");
        }
    }
}
