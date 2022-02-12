using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainTicket.Migrations
{
    public partial class ticket1111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrainID",
                table: "ticketInformations",
                newName: "TrainName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrainName",
                table: "ticketInformations",
                newName: "TrainID");
        }
    }
}
