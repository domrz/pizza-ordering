using System;
namespace PizzaOrdering.Models
{
    public class CustomerUser
    {
        public string Name { get; set; }

        public string Email { get; set; }

        private string Password { get; set; }

        public string Phone { get; set; }

        public Order Orders { get; set; }

        public string Address { get; set; }
    }
}
