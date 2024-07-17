using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class newchapter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GstTax",
                table: "paymentCustomeExtraUserModels");

            migrationBuilder.DropColumn(
                name: "LicenceDays",
                table: "paymentCustomeExtraUserModels");

            migrationBuilder.DropColumn(
                name: "OtherCharges",
                table: "paymentCustomeExtraUserModels");

            migrationBuilder.DropColumn(
                name: "ValidForMonth",
                table: "paymentCustomeExtraUserModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GstTax",
                table: "paymentCustomeExtraUserModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LicenceDays",
                table: "paymentCustomeExtraUserModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OtherCharges",
                table: "paymentCustomeExtraUserModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ValidForMonth",
                table: "paymentCustomeExtraUserModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
