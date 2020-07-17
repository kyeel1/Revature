using System;
using System.Collections.Generic;
using PizzaStore.Domain;
namespace PizzaStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User();
            var store1 = new Store();
            var Startup = new Startup();
            Order cart = Startup.CreateOrder(user1,store1);
            bool flag = true;
            while(flag){
                flag = newInput();
            }
            bool newInput()
            {
             Console.WriteLine("type cheese if you want top add a cheese pizza to the cart");
             Console.WriteLine("type peperoni if you want peperoni");
             Console.WriteLine("type sausage if you want suasage");
             Console.WriteLine("type custom if you want a custom pizza");
             Console.WriteLine("type cart to display the cart");
             
             Console.WriteLine("press enter if you want to exit");
             var temp = new PizzaStore.Client.Startup();
             Pizza tempPizza;
                switch(Console.ReadLine())
                {
                 case "cheese":
                 tempPizza = new Pizza("L","thick",new List<string>{"cheese"});
                 cart.pizzas.Add(tempPizza);
                 break;

                 case "pepperoni" :
                 tempPizza = new Pizza("L","thick",new List<string>{"cheese"});
                 cart.pizzas.Add(tempPizza);
                 break;

                 case "suasage": 
                 tempPizza = new Pizza("L","thick",new List<string>{"cheese"});
                 cart.pizzas.Add(tempPizza);
                 break;

                 case "custom" :
                 tempPizza = new Pizza("L","thick",custom());
                 cart.pizzas.Add(tempPizza);
                 break;
                 case "cart":
                 foreach(Pizza x in cart.pizzas){
                     Console.WriteLine($"{x.ToString()}");
                 }
                 break;

                 default:
                 return false;
                }
             return true;//returns the result of the operation
            
            }
            List<string> custom(){
                bool flag = true;
                List<string> customPizza = new List<string>();
                int customIndex=0;
                while(flag){
                Console.WriteLine("you may only add three toppingsto your pizza");
                Console.WriteLine("type cheese if you want top add a cheese pizza to the cart");
                Console.WriteLine("type peperoni if you want peperoni");
                Console.WriteLine("type sausage if you want suasage");
                Console.WriteLine("press enter if you want to exit");

                switch(Console.ReadLine())
                {
                 case "cheese":
                 customPizza.Add("cheese");
                 break;

                 case "pepperoni" :
                 customPizza.Add("Pepperoni");
                 break;

                 case "suasage": 
                 customPizza.Add("suasage");
                 break;

                 default:
                 flag = false;
                 break;
                }
                if(customIndex ==3)
                 flag = false;
                }
                return customPizza;
            }
        }
    }
}
