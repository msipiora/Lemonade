using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade;

namespace Lemonade
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWeather()
        {
            //Arrange 
            int botomOFRange = 50;
            int topOfRange = 100;
            //Act
            Weather weather = new Weather();
            //Assert
            Assert.IsTrue(weather.Temperature > botomOFRange && weather.Temperature < topOfRange);
            
            
        }
        [TestMethod]
        public void TestGlassCounter()
        {
            Pitcher pitcher = new Pitcher();
            Player player = new Player();
            //Arrange
            player.Inventory.CupList.Add(new Cup());
            //Act
            pitcher.PourGlass(player);
 
            //Assert
            Assert.IsTrue(pitcher.GlassCounter > 0);
        }
        [TestMethod]

        public void CupListRemove()
        {

            Player player = new Player();
            Pitcher pitcher = new Pitcher();

            //Arrange
            player.Inventory.CupList.Clear();
            player.Inventory.CupList.Add(new Cup());
            //Act
            pitcher.PourGlass(player);
            //Assert
            Assert.AreEqual(0, player.Inventory.CupList.Count);
        }
        [TestMethod]

        public void CheckIngredients()
        {
            Pitcher pitcher = new Pitcher();
            Player player = new Player();

            //Arrange
            player.Inventory.LemonList.Clear();
            player.Inventory.LemonList.Add(new Lemon());
            player.Inventory.LemonsUsed = 0;
            player.Inventory.SugarList.Clear();
            player.Inventory.SugarList.Add(new Sugar());
            player.Inventory.SugarUsed = 0;
            //Act
            pitcher.CheckIngredients(player);
            //Assert
            Assert.IsTrue(pitcher.CheckIngredients(player));
        }
        [TestMethod]

        public void CustomerWeatherCheck()
        {
            Customer SampleCustomer = new Customer(70, 1, 1, 1, 1, 1);
            Weather weather = new Weather();
            Day NewDay = new Day(weather);


            //Arrange
            weather.Condition = "Sunny";
            weather.Temperature = 80;

            //Act

            NewDay.CustomerAvailability(SampleCustomer);

            Assert.IsTrue(NewDay.CustomerAvailability(SampleCustomer));

        }
    }
}
