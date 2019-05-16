using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantData;
using RestaurantData.Data;

namespace Restaurant.Test
{
    [TestClass]
    public class UnitTestCrud
    {
        [TestMethod]
        public void TestGetRestaurantsById()
        {
            //Some code
            //Arrange
            ICrud c = new Crud();
            string expectedRestaurant = "Taco Bell";
            //Act
            var actualRestaurant=c.GetRestaurants(2).Name;
            //Assert
            Assert.AreEqual(expectedRestaurant, actualRestaurant);

        }
    }
}
