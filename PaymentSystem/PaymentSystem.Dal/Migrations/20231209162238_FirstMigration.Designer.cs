﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentSystem.Dal;

#nullable disable

namespace PaymentSystem.Dal.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231209162238_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PaymentSystem.Domain.Models.Customer", b =>
                {
                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionHistory")
                        .HasColumnType("int");

                    b.HasKey("NationalId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PaymentSystem.Domain.Models.Merchant", b =>
                {
                    b.Property<string>("MerchantNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AverageTransactionVolume")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BusinessIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfEstablishment")
                        .HasColumnType("datetime2");

                    b.Property<string>("MerchantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchantSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MerchantNumber");

                    b.ToTable("Merchants");
                });
#pragma warning restore 612, 618
        }
    }
}
