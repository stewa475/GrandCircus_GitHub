using System;
using System.Collections.Generic;
using Xunit;
using POS_Terminal;

namespace POS_Test
{
    public class ReceiptTest
    {

        //--------------------------------------------------------------------------------
        //-------------------------------- INVENTORY -------------------------------------
        //--------------------------------------------------------------------------------
        [Fact]
        public void Instantiation()
        {
            Receipt rec = new Receipt();
        }

        [Fact]
        public void GrandTotalTest()
        {
            double subTotal = 1.5;
            double tax = 0.25;
            double grandTotal;
            grandTotal = subTotal + tax;

            Assert.Equal(grandTotal, Receipt.GetGrandTotal(subTotal, tax));
        }

        [Fact]
        public void TaxTest()
        {
            double subTotal = 1.5;
            double tax = subTotal * 0.06;

            Assert.Equal(tax, Receipt.GetTax(subTotal));
        }

        [Fact]
        public void AddCartTest()
        {
            //Arrange
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory.Add("Hamburger", 10);
            //Act
            Receipt inv = new Receipt();
            //Assert
            Assert.Equal(inventory, inv.AddToCart("Hamburger", 10));
        }

        [Fact]
        public void RemoveCartTest()
        {
            //Arrange
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            //Act
            Receipt inv = new Receipt();
            inv.AddToCart("Hamburger", 10);
            //Assert
            Assert.Equal(inventory, inv.RemoveFromCart("Hamburger"));
        }
    }
}
