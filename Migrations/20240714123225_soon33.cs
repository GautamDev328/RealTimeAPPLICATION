using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    /// <inheritdoc />
    public partial class soon33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "citys",
                columns: table => new
                {
                    City_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citys", x => x.City_Id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customerPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerExtraPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerExtraUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    Dep_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dep_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dep_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dep_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesigName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.Dep_Id);
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
                name: "employeeProfiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeProfiles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employeeQuery",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeQueryMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GetDateOnly = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeQuery", x => x.Emp_Id);
                });

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    Gen_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gen_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.Gen_Id);
                });

            migrationBuilder.CreateTable(
                name: "paymentCustomeExtraUserModels",
                columns: table => new
                {
                    paymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Device_Serial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenceDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidForMonth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GstTax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherCharges = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentCustomeExtraUserModels", x => x.paymentId);
                });

            migrationBuilder.CreateTable(
                name: "relationModels",
                columns: table => new
                {
                    Relat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Relation_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userTrails",
                columns: table => new
                {
                    UsertrailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorporateId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Confrompassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DealerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photodrop = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTrails", x => x.UsertrailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "citys");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "customerPrices");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "designations");

            migrationBuilder.DropTable(
                name: "employeeProfiles");

            migrationBuilder.DropTable(
                name: "employeeQuery");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "paymentCustomeExtraUserModels");

            migrationBuilder.DropTable(
                name: "relationModels");

            migrationBuilder.DropTable(
                name: "roleWise");

            migrationBuilder.DropTable(
                name: "RoleWiseOnlyEmployees");

            migrationBuilder.DropTable(
                name: "states");

            migrationBuilder.DropTable(
                name: "userTrails");
        }
    }
}
