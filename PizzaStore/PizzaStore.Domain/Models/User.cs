using System.Collections.Generic;
namespace PizzaStore.Domain
{
    public class User
    {
        public string Name{get;}
        public List<Order> orders{get;}
        public User(string name)
        {
            Name = name;
            orders = new List<Order>();
        }
    }
    
}