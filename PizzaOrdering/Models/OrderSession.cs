using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace PizzaOrdering.Models
{
    public class OrderSession
    {

        private ISession session { get; set; }
        public OrderSession(ISession session)
        {
             this.session = session;
        }

        // Getters and setters for session states

        public List<Pizza> GetPizzas() => session.GetObject<List<Pizza>>("pizzas");
        public void SetPizzas(List<Pizza> pizzas) => session.SetObject("pizzas", pizzas);

        public string GetOrderType() => session.GetString("ordertype");
        public void SetOrderType(string ordertype) => session.SetString("ordertype", ordertype);

        public string GetDeliveryAddress() => session.GetString("deliveryaddress");
        public void SetDeliveryAddress(string deliveryaddress) => session.SetString("deliveryaddress", deliveryaddress);

        public string GetSubtotal() => session.GetString("subtotal");
        public void SetSubtotal(string newsubtotal) => session.SetString("subtotal", newsubtotal);

        public string GetTax() => session.GetString("tax");
        public void SetTax(string newtax) => session.SetString("tax", newtax);

        public void ClearOrder()
        {
            session.Remove("pizzas");
            session.Remove("ordertype");
            session.Remove("deliveryaddress");
            session.Remove("subtotal");
            session.Remove("tax");
        }

        public void ClearPizzas()
        {
            session.Remove("pizzas");
            session.Remove("subtotal");
            session.Remove("tax");
        }


    }
}
