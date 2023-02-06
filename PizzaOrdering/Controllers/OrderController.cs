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
    public class OrderController : Controller
    {

        private PizzaOrderingContext context { get; set; }

        public OrderController(PizzaOrderingContext ctx)
        {
            context = ctx;
        }

        public IActionResult PlaceOrder()
        {
            var session = new OrderSession(HttpContext.Session);
            ViewBag.Action = "PlaceOrder";

            if(HttpContext.Session.GetString("pizzas") == null)
            {
                session.SetPizzas(new List<Pizza>());
            }

            return View("OrderUI");
        }

        public IActionResult ClearOrder()
        {
            var session = new OrderSession(HttpContext.Session);
            session.ClearPizzas();
            session.SetPizzas(new List<Pizza>());

            return View("OrderUI");
        }

        [HttpPost] // sets order type and delivery address if delivery
        public IActionResult SaveInfo(string OrderType, string DeliveryAddress)
        {
            var session = new OrderSession(HttpContext.Session);

            session.SetOrderType(OrderType);
            if(OrderType == "Delivery")
            {
                session.SetDeliveryAddress(DeliveryAddress);
            }

            return RedirectToAction("PlaceOrder");
        }

        // SubmitOrder places the order by pulling current order info from session states
        // and creating a new Order instance and saving it to the database
        [HttpPost] 
        public IActionResult SubmitOrder()
        {
            var session = new OrderSession(HttpContext.Session);

            var pizzas = session.GetPizzas();
            var ordertype = session.GetOrderType();
            var deliveryaddress = session.GetDeliveryAddress();
            var subtotal = Convert.ToDecimal(session.GetSubtotal());
            var tax = Convert.ToDecimal(session.GetTax());

            Order order = new()
            {
                OrderType = ordertype,
                OrderDate = DateTime.Now,
                DeliveryAddress = deliveryaddress,
                Subtotal = subtotal,
                Tax = tax,
                OrderTotal = subtotal + tax,
                Status = "Preparing"  
            };

            order.Pizzas = new List<Pizza>();

            context.Orders.Add(order);
            foreach (var pizza in pizzas)
            {
                context.Pizzas.Add(pizza);
                order.Pizzas.Add(pizza);
            }

            context.SaveChanges();
            session.ClearOrder();
            return View("ViewOrderDetails", order);
        }


        [HttpGet]
        public IActionResult ViewOrders()
        {
            List<Order> orders = context.Orders.ToList();
            ViewBag.Action = "ViewOrders";
            return View(orders);
        }

        [HttpGet]
        public IActionResult ViewOrdersEmp()
        {
            List<Order> orders = context.Orders.ToList();
            ViewBag.Action = "ViewOrdersEmp";
            return View(orders);
        }

        // ViewOrderDetails responsible for fetching order details from database based on order ID
        [HttpGet]
        public IActionResult ViewOrderDetails(int id)
        {
            var order = context.Orders.Find(id);
            ViewBag.Action = "ViewOrderDetails";

            IQueryable<Pizza> query = context.Pizzas;
            query = query.Where(p => p.OrderID == order.ID);

            List<Pizza> pizzas = query.ToList(); 

            IQueryable<Topping> tquery = context.Toppings;
            List<Topping> toppings = new List<Topping>();
            foreach(var pizza in pizzas)
            {
                tquery = tquery.Where(t => t.PizzaID == pizza.ID);
                foreach(var topping in tquery) { toppings.Add(topping); }
                tquery = context.Toppings;
            }

            ViewBag.Pizzas = pizzas;
            ViewBag.Toppings = toppings;

            return View(order);
        }

        [HttpGet]
        public IActionResult ViewOrderDetailsEmp(int id)
        {
            var order = context.Orders.Find(id);
            ViewBag.Action = "ViewOrderDetailsEmp";

            IQueryable<Pizza> query = context.Pizzas;
            query = query.Where(p => p.OrderID == order.ID);

            List<Pizza> pizzas = query.ToList();

            IQueryable<Topping> tquery = context.Toppings;
            List<Topping> toppings = new List<Topping>();
            foreach (var pizza in pizzas)
            {
                tquery = tquery.Where(t => t.PizzaID == pizza.ID);
                foreach (var topping in tquery) { toppings.Add(topping); }
                tquery = context.Toppings;
            }

            ViewBag.Pizzas = pizzas;
            ViewBag.Toppings = toppings;

            return View(order);
        }


        [HttpPost]
        public IActionResult UpdateStatus(int id, string newStatus)
        {

            var order = context.Orders.Find(id);
            order.Status = newStatus;
            context.SaveChanges();

            IQueryable<Pizza> query = context.Pizzas;
            query = query.Where(p => p.OrderID == order.ID);

            List<Pizza> pizzas = query.ToList();

            ViewBag.Pizzas = pizzas;

            List<Order> orders = context.Orders.ToList();
            return View("ViewOrdersEmp", orders);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
