using System.Collections.Generic;
namespace PizzaStore.Domain
{
    public class Order
    {
        public List<Pizza> pizzas = new List<Pizza>();

        public void createPizza(string crust, string size, List<string> toppings, double cost){
            pizzas.Add(new Pizza(crust,size,toppings,cost));
        }
    }
}