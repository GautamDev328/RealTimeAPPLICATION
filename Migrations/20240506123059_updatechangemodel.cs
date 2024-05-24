using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class updatechangemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminLoginHRLOGIN");

            migrationBuilder.AddColumn<int>(
                name: "AdminLoginAdmin_Id",
                table: "hrlogin",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_hrlogin_AdminLoginAdmin_Id",
                table: "hrlogin",
                column: "AdminLoginAdmin_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_hrlogin_adminlogin_AdminLoginAdmin_Id",
                table: "hrlogin",
                column: "AdminLoginAdmin_Id",
                principalTable: "adminlogin",
                principalColumn: "Admin_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hrlogin_adminlogin_AdminLoginAdmin_Id",
                table: "hrlogin");

            migrationBuilder.DropIndex(
                name: "IX_hrlogin_AdminLoginAdmin_Id",
                table: "hrlogin");

            migrationBuilder.DropColumn(
                name: "AdminLoginAdmin_Id",
                table: "hrlogin");

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

            migrationBuilder.CreateIndex(
                name: "IX_AdminLoginHRLOGIN_adminLoginsAdmin_Id",
                table: "AdminLoginHRLOGIN",
                column: "adminLoginsAdmin_Id");
        }
    }
}
