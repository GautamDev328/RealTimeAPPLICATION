using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class updatetoolDoB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "employeeProfiles");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "employeeProfiles",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "employeeProfiles");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "employeeProfiles",
                type: "datetime2",
                nullable: true);
        }
    }
}
