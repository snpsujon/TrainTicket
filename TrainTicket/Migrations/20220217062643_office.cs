using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTicket.Migrations
{
    public partial class office : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketID",
                table: "bookingInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TicketQuantity",
                table: "bookingInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TicketTotalPrice",
                table: "bookingInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketID",
                table: "bookingInformations");

            migrationBuilder.DropColumn(
                name: "TicketQuantity",
                table: "bookingInformations");

            migrationBuilder.DropColumn(
                name: "TicketTotalPrice",
                table: "bookingInformations");
        }
    }
}
