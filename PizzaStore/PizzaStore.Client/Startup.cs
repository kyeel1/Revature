using System.Collections.Generic;
using PizzaStore.Domain;
namespace PizzaStore.Client
{
 public class Startup
 {
  public Pizza CreatePizza(string size,string crust,List<string> toppings)
  {
   var pizza = new Pizza();
   pizza.size = size;
   pizza.crust = crust;
   pizza.toppings = toppings;
   return pizza;

  }
 }
}
