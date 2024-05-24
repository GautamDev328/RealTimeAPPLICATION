using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class changemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roleWise_Only_Employee_Data_Search_s");

            migrationBuilder.CreateTable(
                name: "RoleWiseOnlyEmployees",
                columns: table => new
                {
                    RoleWiseonlyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleWiseonlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleWiseOnlyEmployees", x => x.RoleWiseonlyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleWiseOnlyEmployees");

            migrationBuilder.CreateTable(
                name: "roleWise_Only_Employee_Data_Search_s",
                columns: table => new
                {
                    RoleWiseonlyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleWiseonlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roleWise_Only_Employee_Data_Search_s", x => x.RoleWiseonlyId);
                });
        }
    }
}
