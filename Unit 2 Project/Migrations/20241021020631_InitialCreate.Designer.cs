﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unit_2_Project.Models;

#nullable disable

namespace Unit_2_Project.Migrations
{
    [DbContext(typeof(EmployeeDBContext))]
    [Migration("20241021020631_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Unit_2_Project.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Berg, David",
                            Position = "Manager",
                            Salary = 75000m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Smith, Arnold",
                            Position = "Salesman",
                            Salary = 50000m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Reham, Amanda",
                            Position = "Supervisor",
                            Salary = 62000m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tylar, Darrin",
                            Position = "Salesman",
                            Salary = 48000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
