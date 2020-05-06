using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eleva.Data.Migrations
{
    public partial class updatestudentclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FinalDate",
                table: "StudentClasses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialDate",
                table: "StudentClasses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StudentClasses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Workload",
                table: "StudentClasses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalDate",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "InitialDate",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StudentClasses");

            migrationBuilder.DropColumn(
                name: "Workload",
                table: "StudentClasses");
        }
    }
}
