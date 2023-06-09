﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserApi.Data;

#nullable disable

namespace UserApi.Migrations.UserDb
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20230530095331_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UserApi.Models.Users", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_id"));

                    b.Property<string>("User_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_cart_id")
                        .HasColumnType("int");

                    b.Property<string>("User_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_favorites_id")
                        .HasColumnType("int");

                    b.Property<string>("User_firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("User_password_salt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("User_phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_id");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
