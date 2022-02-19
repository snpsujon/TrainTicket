using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTicket.Migrations
{
    public partial class mypc1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "userInformations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalTicketsAllTime",
                table: "ticketInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BookingAttachment",
                table: "bookingInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookingStatus",
                table: "bookingInformations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "userInformations");

            migrationBuilder.DropColumn(
                name: "TotalTicketsAllTime",
                table: "ticketInformations");

            migrationBuilder.DropColumn(
                name: "BookingAttachment",
                table: "bookingInformations");

            migrationBuilder.DropColumn(
                name: "BookingStatus",
                table: "bookingInformations");
        }
    }
}
