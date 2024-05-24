

using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class updatesoonEmployeequery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeQueryMessage",
                table: "employeeQuery",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeQueryMessage",
                table: "employeeQuery");
        }
    }
}
