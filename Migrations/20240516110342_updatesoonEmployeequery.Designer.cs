﻿// <auto-generated />
using System;
using CRUDAPPLICATION.DATABASE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDAPPLICATION.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    [Migration("20240516110342_updatesoonEmployeequery")]
    partial class updatesoonEmployeequery
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUDAPPLICATION.Model.City", b =>
                {
                    b.Property<int>("City_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("City_Id"));

                    b.Property<string>("City_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("City_Id");

                    b.ToTable("citys");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.CustomerPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerExtraPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerExtraUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("customerPrices");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.Department", b =>
                {
                    b.Property<int>("Dep_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dep_Id"));

                    b.Property<string>("Dep_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dep_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dep_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesigName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Dep_Id");

                    b.ToTable("department");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.DesignationModel", b =>
                {
                    b.Property<int>("DesigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesigId"));

                    b.Property<string>("DesigDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesigName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesigType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesigId");

                    b.ToTable("designations");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.EmployeeProfile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("employeeProfiles");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.EmployeeQuery", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_Id"));

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeQueryMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_Id");

                    b.ToTable("employeeQuery");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.Gender", b =>
                {
                    b.Property<int>("Gen_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Gen_Id"));

                    b.Property<string>("Gen_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Gen_Id");

                    b.ToTable("gender");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.RelationModel", b =>
                {
                    b.Property<int>("Relat_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Relat_Id"));

                    b.Property<string>("Relation_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Relat_Id");

                    b.ToTable("relationModels");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.RoleWiseModel", b =>
                {
                    b.Property<int>("Role_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Role_ID"));

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Role_ID");

                    b.ToTable("roleWise");
                });

            modelBuilder.Entity("CRUDAPPLICATION.Model.StateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StateId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("states");
                });
#pragma warning restore 612, 618
        }
    }
}
