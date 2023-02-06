using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaOrdering.Context;
using PizzaOrdering.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace PizzaOrdering.Controllers
{
    public class PizzaController : Controller
    {

        private PizzaOrderingContext context { get; set; }

        public PizzaController(PizzaOrderingContext ctx)
        {
            context = ctx;
        }

        // this is called when the user adds a pizza to their order from the form on the OrderUI.
        // does not interact with database, only session states
        public IActionResult AddPizza(Pizza pizza, string PizzaType, bool Pepperoni, bool Sausage, bool Bacon, bool Mushrooms, bool Onions, bool ExtraCheese, int Quantity)
        {
            if (ModelState.IsValid)
            {
                var session = new OrderSession(HttpContext.Session);
                var pizzas = session.GetPizzas();
                string subtotalString = session.GetSubtotal();
                decimal subtotal = System.Convert.ToDecimal(subtotalString);

                //pizza.OrderID = order.ID;
                pizza.PizzaType = PizzaType;

                if (PizzaType == "Classic") { pizza.Price = (decimal)13.00; }
                if (PizzaType == "Thin Crust") { pizza.Price = (decimal)12.00; }
                if (PizzaType == "Deep Dish") { pizza.Price = (decimal)14.00; }
                if (PizzaType == "Cecilian") { pizza.Price = (decimal)16.00; }

                pizza.Toppings = new List<Topping>();
                if (Pepperoni) { pizza.Toppings.Add(new Topping { Name = "Pepperoni", Price = (decimal)1.25 }); }
                if (Sausage) { pizza.Toppings.Add(new Topping { Name = "Sausage", Price = (decimal)1.50 }); }
                if (Bacon) { pizza.Toppings.Add(new Topping { Name = "Bacon", Price = (decimal)1.50 }); }
                if (Mushrooms) { pizza.Toppings.Add(new Topping { Name = "Mushrooms", Price = (decimal).75 }); }
                if (Onions) { pizza.Toppings.Add(new Topping { Name = "Onions", Price = (decimal).50 }); }
                if (ExtraCheese) { pizza.Toppings.Add(new Topping { Name = "Extra Cheese", Price = (decimal)1.00 }); }


                foreach (var topping in pizza.Toppings) { pizza.Price += topping.Price; }
                pizza.Price *= Quantity;

                subtotal += pizza.Price;
                decimal tax = subtotal * (decimal)0.07;

                pizzas.Add(pizza);
                session.SetPizzas(pizzas);
                session.SetSubtotal(subtotal.ToString());
                session.SetTax(tax.ToString());

            }

            return RedirectToAction("PlaceOrder", "Order");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
