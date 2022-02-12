using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTicket.Migrations
{
    public partial class ticket111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromStationID",
                table: "ticketInformations");

            migrationBuilder.DropColumn(
                name: "ToStationID",
                table: "ticketInformations");

            migrationBuilder.DropColumn(
                name: "StationID",
                table: "fromStations");

            migrationBuilder.AddColumn<string>(
                name: "FStarionName",
                table: "ticketInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TStationName",
                table: "ticketInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FStarionName",
                table: "fromStations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FStarionName",
                table: "ticketInformations");

            migrationBuilder.DropColumn(
                name: "TStationName",
                table: "ticketInformations");

            migrationBuilder.DropColumn(
                name: "FStarionName",
                table: "fromStations");

            migrationBuilder.AddColumn<int>(
                name: "FromStationID",
                table: "ticketInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ToStationID",
                table: "ticketInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StationID",
                table: "fromStations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
