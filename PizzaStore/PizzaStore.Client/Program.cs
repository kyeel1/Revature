using System;
using System.Collections.Generic;
using PizzaStore.Domain;
namespace PizzaStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza[] cart = new Pizza[3];
            int index = 0;
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
             Console.WriteLine("press enter if you want to exit");
             var temp = new PizzaStore.Client.Startup();
             var tempPizza = new Pizza();
                switch(Console.ReadLine())
                {
                 case "cheese":
                 tempPizza = temp.CreatePizza("L","thick",new List<string>{"cheese"});
                 cart[index] = tempPizza;
                 index += 1;
                 break;

                 case "pepperoni" :
                 tempPizza = temp.CreatePizza("L","thick",new List<string>{"cheese"});
                 cart[index] = tempPizza;
                 index += 1;
                 break;

                 case "suasage": 
                 tempPizza = temp.CreatePizza("L","thick",new List<string>{"cheese"});
                 cart[index] = tempPizza;
                 index += 1;
                 break;

                 case "custom" :
                 tempPizza = temp.CreatePizza("L","thick",custom());
                 cart[index] = tempPizza;
                 index += 1;
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
