using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class changeDeviceSerial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Device_Serial",
                table: "paymentCustomeExtraUserModels",
                newName: "Device_Serials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Device_Serials",
                table: "paymentCustomeExtraUserModels",
                newName: "Device_Serial");
        }
    }
}
