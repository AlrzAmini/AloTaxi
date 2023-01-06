using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AloTaxi.Data.Migrations
{
    public partial class ChangeTblDriverCars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverCars_Cars_CarId1",
                table: "DriverCars");

            migrationBuilder.DropIndex(
                name: "IX_DriverCars_CarId1",
                table: "DriverCars");

            migrationBuilder.DropColumn(
                name: "CarId1",
                table: "DriverCars");

            migrationBuilder.AlterColumn<long>(
                name: "CarId",
                table: "DriverCars",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverCars_CarId",
                table: "DriverCars",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverCars_Cars_CarId",
                table: "DriverCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DriverCars_Cars_CarId",
                table: "DriverCars");

            migrationBuilder.DropIndex(
                name: "IX_DriverCars_CarId",
                table: "DriverCars");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "DriverCars",
                type: "int",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CarId1",
                table: "DriverCars",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverCars_CarId1",
                table: "DriverCars",
                column: "CarId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverCars_Cars_CarId1",
                table: "DriverCars",
                column: "CarId1",
                principalTable: "Cars",
                principalColumn: "Id");
        }
    }
}
