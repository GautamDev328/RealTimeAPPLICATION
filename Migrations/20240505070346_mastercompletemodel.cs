using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class mastercompletemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State_Name",
                table: "citys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "adminlogin",
                columns: table => new
                {
                    Admin_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admine_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admine_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admine_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admine_Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminlogin", x => x.Admin_Id);
                });

            migrationBuilder.CreateTable(
                name: "designations",
                columns: table => new
                {
                    DesigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesigName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesigDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesigType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_designations", x => x.DesigId);
                });

            migrationBuilder.CreateTable(
                name: "hrlogin",
                columns: table => new
                {
                    HR_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HR_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HR_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HR_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HR_Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hrlogin", x => x.HR_Id);
                });

            migrationBuilder.CreateTable(
                name: "relationModels",
                columns: table => new
                {
                    Relat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Relation_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relationModels", x => x.Relat_Id);
                });

            migrationBuilder.CreateTable(
                name: "roleWise",
                columns: table => new
                {
                    Role_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roleWise", x => x.Role_ID);
                });

            migrationBuilder.CreateTable(
                name: "AdminLoginHRLOGIN",
                columns: table => new
                {
                    HrLoginHR_Id = table.Column<int>(type: "int", nullable: false),
                    adminLoginsAdmin_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminLoginHRLOGIN", x => new { x.HrLoginHR_Id, x.adminLoginsAdmin_Id });
                    table.ForeignKey(
                        name: "FK_AdminLoginHRLOGIN_adminlogin_adminLoginsAdmin_Id",
                        column: x => x.adminLoginsAdmin_Id,
                        principalTable: "adminlogin",
                        principalColumn: "Admin_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminLoginHRLOGIN_hrlogin_HrLoginHR_Id",
                        column: x => x.HrLoginHR_Id,
                        principalTable: "hrlogin",
                        principalColumn: "HR_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLogins",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminLoginAdmin_Id = table.Column<int>(type: "int", nullable: true),
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
                name: "IX_AdminLoginHRLOGIN_adminLoginsAdmin_Id",
                table: "AdminLoginHRLOGIN",
                column: "adminLoginsAdmin_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogins_AdminLoginAdmin_Id",
                table: "EmployeeLogins",
                column: "AdminLoginAdmin_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogins_HRLOGINHR_Id",
                table: "EmployeeLogins",
                column: "HRLOGINHR_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminLoginHRLOGIN");

            migrationBuilder.DropTable(
                name: "designations");

            migrationBuilder.DropTable(
                name: "EmployeeLogins");

            migrationBuilder.DropTable(
                name: "relationModels");

            migrationBuilder.DropTable(
                name: "roleWise");

            migrationBuilder.DropTable(
                name: "adminlogin");

            migrationBuilder.DropTable(
                name: "hrlogin");

            migrationBuilder.DropColumn(
                name: "State_Name",
                table: "citys");
        }
    }
}
