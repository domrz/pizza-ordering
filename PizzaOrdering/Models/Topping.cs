using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PizzaOrdering.Models
{
    
    public class Topping
    {
        public Topping()
        { }

        public Topping(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        [Key]
        public int ID { get; set; }

        [ForeignKey("PizzaID")]
        public int PizzaID { get; set; }

        public Pizza Pizza { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool Selected { get; set; }

        
    }
}
