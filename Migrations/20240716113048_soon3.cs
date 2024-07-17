using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class soon3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenceDays",
                table: "paymentCustomeExtraUserModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LicenceDays",
                table: "paymentCustomeExtraUserModels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
