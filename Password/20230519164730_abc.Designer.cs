﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Patient_Registration_System.Views;

#nullable disable

namespace Patient_Registration_System.Migrations.Password
{
    [DbContext(typeof(PasswordContext))]
    [Migration("20230519164730_abc")]
    partial class abc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Patient_Registration_System.Views.Password", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Passwrd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Passwords");
                });
#pragma warning restore 612, 618
        }
    }
}
