using System;
using System.Collections.Generic;
using Xunit;
using POS_Terminal;

namespace POS_Test
{
    public class InventoryTest
    {

        //--------------------------------------------------------------------------------
        //-------------------------------- INVENTORY -------------------------------------
        //--------------------------------------------------------------------------------
        [Fact]
        public void Instantiation()
        {
            Inventory inv = new Inventory();
        }

        [Fact]
        public void AddProductTest()
        {
            //Arrange
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory.Add("Hamburger", 120);
            //Act
            Inventory inv = new Inventory();
            //Assert
            Assert.Equal(inventory, inv.AddProduct("Hamburger", 120));
        }

        [Fact]
        public void RemoveProductTest()
        {
            //Arrange
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            //Act
            Inventory inv = new Inventory();
            inv.AddProduct("Hamburger", 120);
            //Assert
            Assert.Equal(inventory, inv.RemoveProduct("Hamburger"));
        }

        [Fact]
        public void RemoveQuantityTest()
        {
            //Arrange
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory.Add("Hamburger", 119);
            //Act
            Inventory inv = new Inventory();
            inv.AddProduct("Hamburger", 120);
            //Assert
            Assert.Equal(inventory, inv.RemoveQuantity("Hamburger", 1));
        }

    }
}
