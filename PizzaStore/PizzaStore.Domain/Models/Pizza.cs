using System.Collections.Generic;
namespace PizzaStore.Domain
{
 public class Pizza
 {
  public string Size = "";
  public string Crust = "";
  public List<string> Toppings = new List<string>();

 public Pizza(string crust,string size, List<string> toppings){
   Crust = crust;
   Size = size;
   Toppings = toppings;

 }
 public override string ToString()
 {
  string result = $"size:{Size} crust:{Crust} toppings:";
  foreach(string x in Toppings)
  {
   result+= $"{x} ";
  }
  return result;
}
}
}