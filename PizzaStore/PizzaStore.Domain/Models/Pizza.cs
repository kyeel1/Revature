using System.Collections.Generic;
namespace PizzaStore.Domain
{
 public class Pizza
 {
  public string size = "";
  public string crust = "";
  public List<string> toppings = new List<string>();
 
 public override string ToString()
 {
  string result = $"size:{size} crust:{crust} toppings:";
  foreach(string x in toppings)
  {
   result+= $"{x} ";
  }
  return result;
}
}
}