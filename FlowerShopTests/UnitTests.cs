using NUnit.Framework;
using FlowerShop;
using NSubstitute;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Act
           
            
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var order = Substitute.For<IOrderDAO>();
            var client = Substitute.For<IClient>();
            Order batch = Substitute.For<Order>(order,client, false);
            //Act and Assert
            batch.Received().Deliver();
            
        }
    }
}