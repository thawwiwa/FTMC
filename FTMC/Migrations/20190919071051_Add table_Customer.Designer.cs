﻿// <auto-generated />
using FTMC.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FTMC.Migrations
{
    [DbContext(typeof(FTMCdb))]
    [Migration("20190919071051_Add table_Customer")]
    partial class Addtable_Customer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FTMC.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CustomerBudget")
                        .HasColumnType("DECIMAL(20,2)");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<decimal>("CustomerUsed")
                        .HasColumnType("DECIMAL(20,2)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
