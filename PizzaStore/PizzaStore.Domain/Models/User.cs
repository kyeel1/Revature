using System.Collections.Generic;
namespace PizzaStore.Domain
{
    public class User
    {
        public string name;
        public List<Order> orders{get;}
        public User()
        {
            orders = new List<Order>();
        }
    }
    
}