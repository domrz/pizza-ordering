﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaOrdering.Context;

namespace PizzaOrdering.Migrations
{
    [DbContext(typeof(PizzaOrderingContext))]
    [Migration("20220505173707_DBInitializationWithSeed")]
    partial class DBInitializationWithSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaOrdering.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OrderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            ID = 1001,
                            DeliveryAddress = "123 Pizza Lane",
                            OrderDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OrderTotal = 30.76m,
                            OrderType = "Delivery",
                            Status = "Complete",
                            Subtotal = 0m,
                            Tax = 0m
                        });
                });

            modelBuilder.Entity("PizzaOrdering.Models.Pizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<string>("PizzaType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            OrderID = 1001,
                            PizzaType = "Classic",
                            Price = 26m,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("PizzaOrdering.Models.Topping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PizzaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Selected")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("PizzaID");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Pepperoni",
                            PizzaID = 1,
                            Price = 1.25m,
                            Selected = false
                        },
                        new
                        {
                            ID = 2,
                            Name = "Sausage",
                            PizzaID = 1,
                            Price = 1.5m,
                            Selected = false
                        });
                });

            modelBuilder.Entity("PizzaOrdering.Models.Pizza", b =>
                {
                    b.HasOne("PizzaOrdering.Models.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("PizzaOrdering.Models.Topping", b =>
                {
                    b.HasOne("PizzaOrdering.Models.Pizza", "Pizza")
                        .WithMany("Toppings")
                        .HasForeignKey("PizzaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");
                });

            modelBuilder.Entity("PizzaOrdering.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaOrdering.Models.Pizza", b =>
                {
                    b.Navigation("Toppings");
                });
#pragma warning restore 612, 618
        }
    }
}