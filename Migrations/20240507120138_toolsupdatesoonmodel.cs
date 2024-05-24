using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class toolsupdatesoonmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeLogins");

            migrationBuilder.DropTable(
                name: "hrlogin");

            migrationBuilder.DropTable(
                name: "adminlogin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adminlogin",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admine_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admine_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admine_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admine_Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminlogin", x => x.Admin_Id);
                });

            migrationBuilder.CreateTable(
                name: "hrlogin",
                columns: table => new
                {
                    HR_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminLoginAdmin_Id = table.Column<int>(type: "int", nullable: true),
                    HR_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HR_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HR_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HR_Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hrlogin", x => x.HR_Id);
                    table.ForeignKey(
                        name: "FK_hrlogin_adminlogin_AdminLoginAdmin_Id",
                        column: x => x.AdminLoginAdmin_Id,
                        principalTable: "adminlogin",
                        principalColumn: "Admin_Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLogins",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminLoginAdmin_Id = table.Column<int>(type: "int", nullable: true),
                    Employee_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HRLOGINHR_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLogins", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_EmployeeLogins_adminlogin_AdminLoginAdmin_Id",
                        column: x => x.AdminLoginAdmin_Id,
                        principalTable: "adminlogin",
                        principalColumn: "Admin_Id");
                    table.ForeignKey(
                        name: "FK_EmployeeLogins_hrlogin_HRLOGINHR_Id",
                        column: x => x.HRLOGINHR_Id,
                        principalTable: "hrlogin",
                        principalColumn: "HR_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogins_AdminLoginAdmin_Id",
                table: "EmployeeLogins",
                column: "AdminLoginAdmin_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogins_HRLOGINHR_Id",
                table: "EmployeeLogins",
                column: "HRLOGINHR_Id");

            migrationBuilder.CreateIndex(
                name: "IX_hrlogin_AdminLoginAdmin_Id",
                table: "hrlogin",
                column: "AdminLoginAdmin_Id");
        }
    }
}
