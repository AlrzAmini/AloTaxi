using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AloTaxi.Data.Migrations
{
    public partial class Change_CustomerIdToUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Drivers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Drivers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Customers",
                newName: "CustomerId");
        }
    }
}
