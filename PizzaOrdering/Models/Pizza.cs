using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PizzaOrdering.Models
{
    
    public class Pizza
    {

        public string PizzaType { get; set; }

        public virtual List<Topping> Toppings { get; set; }

        [Key]
        public int ID { get; set; }

        [ForeignKey("OrderID")]
        public int OrderID { get; set; }

        public Order Order { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}

    
