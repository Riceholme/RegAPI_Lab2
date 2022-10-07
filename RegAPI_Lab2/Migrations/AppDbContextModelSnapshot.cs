﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegAPI_Lab2.Models;

#nullable disable

namespace RegAPI_Lab2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RegAPI_Lab2.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "We like numbers and profit",
                            Name = "Economy"
                        },
                        new
                        {
                            Id = 2,
                            Description = "System development and digitization",
                            Name = "IT"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Markets our company and products",
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Description = "We sold our soul to sell",
                            Name = "Sales"
                        });
                });

            modelBuilder.Entity("RegAPI_Lab2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "fågelvägen 4",
                            DepartmentId = 1,
                            Email = "kalle@anka.se",
                            FirstName = "Kalle",
                            Gender = "Man",
                            LastName = "Anka",
                            PhoneNumber = "0706655221",
                            Salary = 30000m
                        },
                        new
                        {
                            Id = 2,
                            Adress = "fjädergatan 3",
                            DepartmentId = 2,
                            Email = "knatte@anka.se",
                            FirstName = "Knatte",
                            Gender = "Man",
                            LastName = "Anka",
                            PhoneNumber = "0703343123",
                            Salary = 30000m
                        },
                        new
                        {
                            Id = 3,
                            Adress = "näbbvägen 34",
                            DepartmentId = 3,
                            Email = "tjatte@anka.se",
                            FirstName = "Tjatte",
                            Gender = "Man",
                            LastName = "Anka",
                            PhoneNumber = "0702122569",
                            Salary = 30000m
                        },
                        new
                        {
                            Id = 4,
                            Adress = "luftgatan 40",
                            DepartmentId = 4,
                            Email = "fnatte@anka.se",
                            FirstName = "Fnatte",
                            Gender = "Man",
                            LastName = "Anka",
                            PhoneNumber = "07032323223",
                            Salary = 30000m
                        });
                });

            modelBuilder.Entity("RegAPI_Lab2.Models.Employee", b =>
                {
                    b.HasOne("RegAPI_Lab2.Models.Department", "Department")
                        .WithMany("EmpsOfDep")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("RegAPI_Lab2.Models.Department", b =>
                {
                    b.Navigation("EmpsOfDep");
                });
#pragma warning restore 612, 618
        }
    }
}
