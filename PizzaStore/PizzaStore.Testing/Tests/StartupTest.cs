using System.Collections.Generic;
using PizzaStore.Domain;
using PizzaStore.Client;
using Xunit;

namespace PizzaStore.Testing
{
    public class StartupTest
    {
        [Fact]
        public void TestCreateOrder()
        {
        //Given
        var user = new User("bob");
        var store = new Store();
        var sut = new Starter();
        //When
        var actual = sut.CreateOrder(user,store);
        //Then
        Assert.NotNull(actual);
        }
        
    }
}