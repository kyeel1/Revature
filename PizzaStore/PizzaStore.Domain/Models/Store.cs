using System.Collections.Generic;
namespace PizzaStore.Domain
{
    public class Store
    {
        public string name;
        public List<Order> orders{get;}
        
        public Store(){
            orders = new List<Order>();
        }
    }
}