using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTicket.Migrations
{
    public partial class ticket1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrainName",
                table: "ticketInformations");

            migrationBuilder.RenameColumn(
                name: "StationID",
                table: "ticketInformations",
                newName: "TrainID");

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

            migrationBuilder.CreateTable(
                name: "fromStations",
                columns: table => new
                {
                    FromStaionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromStationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fromStations", x => x.FromStaionID);
                });

            migrationBuilder.CreateTable(
                name: "toStations",
                columns: table => new
                {
                    ToStaionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToStationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toStations", x => x.ToStaionID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fromStations");

            migrationBuilder.DropTable(
                name: "toStations");

            migrationBuilder.DropColumn(
                name: "FromStationID",
                table: "ticketInformations");

            migrationBuilder.DropColumn(
                name: "ToStationID",
                table: "ticketInformations");

            migrationBuilder.RenameColumn(
                name: "TrainID",
                table: "ticketInformations",
                newName: "StationID");

            migrationBuilder.AddColumn<string>(
                name: "TrainName",
                table: "ticketInformations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
