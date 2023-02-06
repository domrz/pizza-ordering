using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaOrdering.Models;

namespace PizzaOrdering.Context
{
    public class PizzaOrderingContext : DbContext
    {
        public PizzaOrderingContext(DbContextOptions<PizzaOrderingContext> options)
           : base(options)
        {}

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // define relationships between orders and pizzas, and pizzas and toppings
            modelBuilder.Entity<Order>().HasMany(o => o.Pizzas).WithOne(p => p.Order);
            modelBuilder.Entity<Pizza>().HasOne(p => p.Order).WithMany(o => o.Pizzas);

            modelBuilder.Entity<Pizza>().HasMany(p => p.Toppings).WithOne(t => t.Pizza);
            modelBuilder.Entity<Topping>().HasOne(t => t.Pizza).WithMany(p => p.Toppings);

            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    ID = 1001,
                    OrderTotal = 30.76m,
                    OrderType = "Delivery",
                    Status = "Complete",
                    DeliveryAddress = "123 Pizza Lane",
                }
            );

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza
                {
                    ID = 1,
                    PizzaType = "Classic",
                    Price = (decimal)26.00,
                    Quantity = 2,
                    OrderID = 1001,

                }
            );

            modelBuilder.Entity<Topping>().HasData(
                new Topping
                {
                    ID = 1,
                    Name = "Pepperoni",
                    Price = (decimal)1.25,
                    PizzaID = 1
                },
                new Topping
                {
                    ID = 2,
                    Name = "Sausage",
                    Price = (decimal)1.50,
                    PizzaID = 1
                }

                );
        }

    }
}
