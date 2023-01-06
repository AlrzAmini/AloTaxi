using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AloTaxi.Data.Migrations
{
    public partial class AddPasswordForAllUserEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarColors_ColorId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverCars_Cars_CarId",
                table: "DriverCars");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverCars_Drivers_DriverId",
                table: "DriverCars");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Managers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Drivers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Drivers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "DriverCars",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Cars",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "CarColors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Addresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarColors_ColorId",
                table: "Cars",
                column: "ColorId",
                principalTable: "CarColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DriverCars_Cars_CarId",
                table: "DriverCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DriverCars_Drivers_DriverId",
                table: "DriverCars",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarColors_ColorId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverCars_Cars_CarId",
                table: "DriverCars");

            migrationBuilder.DropForeignKey(
                name: "FK_DriverCars_Drivers_DriverId",
                table: "DriverCars");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "DriverCars");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "CarColors");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Addresses");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarColors_ColorId",
                table: "Cars",
                column: "ColorId",
                principalTable: "CarColors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverCars_Cars_CarId",
                table: "DriverCars",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DriverCars_Drivers_DriverId",
                table: "DriverCars",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "UserId");
        }
    }
}
