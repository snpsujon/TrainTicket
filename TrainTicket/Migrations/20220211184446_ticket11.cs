using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTicket.Migrations
{
    public partial class ticket11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToStationName",
                table: "toStations");

            migrationBuilder.DropColumn(
                name: "FromStationName",
                table: "fromStations");

            migrationBuilder.AddColumn<int>(
                name: "StationID",
                table: "toStations",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StationID",
                table: "toStations");

            migrationBuilder.DropColumn(
                name: "StationID",
                table: "fromStations");

            migrationBuilder.AddColumn<string>(
                name: "ToStationName",
                table: "toStations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromStationName",
                table: "fromStations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
