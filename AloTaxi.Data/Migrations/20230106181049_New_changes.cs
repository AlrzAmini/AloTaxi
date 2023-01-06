using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AloTaxi.Data.Migrations
{
    public partial class New_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Logs",
                newName: "CreateDate");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Logs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Logs",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Logs",
                newName: "CreatedAt");
        }
    }
}
