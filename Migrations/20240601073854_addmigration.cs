using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class addmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "adminlogin",
                newName: "AdminPassword");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "adminlogin",
                newName: "AdminName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdminPassword",
                table: "adminlogin",
                newName: "UserPassword");

            migrationBuilder.RenameColumn(
                name: "AdminName",
                table: "adminlogin",
                newName: "UserName");
        }
    }
}
