using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class updatessonw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LicenceDays",
                table: "paymentCustomeExtraUserModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherCharges",
                table: "paymentCustomeExtraUserModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenceDays",
                table: "paymentCustomeExtraUserModels");

            migrationBuilder.DropColumn(
                name: "OtherCharges",
                table: "paymentCustomeExtraUserModels");
        }
    }
}
