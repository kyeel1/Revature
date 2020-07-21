using System.Collections.Generic;
namespace PizzaStore.Domain
{
 public class Pizza
 {
  public string Size {get; }
  public string Crust {get; }
  public List<string> Toppings = new List<string>();

  public double Cost {get; }
 public Pizza(string crust,string size, List<string> toppings, double cost){
   Crust = crust;
   Size = size;
   Toppings = toppings;
   Cost = cost;

 }
 public override string ToString()
 {
  string result = $"size:{Size} crust:{Crust} toppings:";
  foreach(string x in Toppings)
  {
   result+= $"{x} ";
  }
  result += $"cost: {Cost}";
  return result;
}
public Pizza()
{

}
}
}