using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class modelchangeadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminPassword",
                table: "adminlogin");

            migrationBuilder.RenameColumn(
                name: "AdminName",
                table: "adminlogin",
                newName: "UserPassword");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "adminlogin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "adminlogin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "adminlogin");

            migrationBuilder.RenameColumn(
                name: "UserPassword",
                table: "adminlogin",
                newName: "AdminName");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "adminlogin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AdminPassword",
                table: "adminlogin",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
