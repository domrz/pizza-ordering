using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrdering.Models
{
    public class Order
    {

        [Key]
        public int ID { get; set; }
        
        public virtual List<Pizza> Pizzas { get; set; }
        
        public DateTime OrderDate { get; set; }

        public decimal Subtotal { get; set; }

        public decimal Tax { get; set; }

        public decimal OrderTotal { get; set; }

        public string OrderType { get; set; }
        
        public string DeliveryAddress { get; set; }

        public string Status { get; set; }
    }
}
