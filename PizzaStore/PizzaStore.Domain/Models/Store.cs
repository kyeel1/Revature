using System.Collections.Generic;
namespace PizzaStore.Domain
{
    public class Store
    {
        public string name;
        public List<Order> orders = new List<Order>();
    }
}