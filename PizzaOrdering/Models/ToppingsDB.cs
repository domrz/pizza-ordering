using System.Collections.Generic;

namespace PizzaOrdering.Models
{
    public class ToppingsDB
    {
        public static List<Topping> GetToppings()
        {
            List<Topping> toppings = new List<Topping>
            {
                new Topping
                {
                    Name = "Pepperoni",
                    Price = (decimal)1.25,
                    Selected = false
                },
                new Topping
                {
                    Name = "Sausage",
                    Price = (decimal)1.50,
                    Selected = false

                },
                new Topping
                {
                    Name = "Mushrooms",
                    Price = (decimal)0.75,
                    Selected = false
                },
                new Topping
                {
                    Name = "Onions",
                    Price = (decimal)0.50,
                    Selected = false
                },
                new Topping
                {
                    Name = "Extra Cheese",
                    Price = (decimal)1.00,
                    Selected = false
                },

            };
            return toppings;
        }
    }
}