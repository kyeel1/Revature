using System.Collections.Generic;
using PizzaStore.Domain;
using Xunit;

namespace PizzaStore.Testing
{
    public class OrderTest
    {
        [Fact]
        public void TestCreatePizza()
        {
        //Given
        Order sut = new Order();
        string size = "L";
        string crust = "thick";
        List<string> toppings = new List<string>();
        //When
        sut.createPizza(size,crust,toppings);
        //Then
        Assert.True(sut.pizzas.Count == 1);
        }
        
    }
}