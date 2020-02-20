using System;
using System.Collections.Generic;
using Xunit;
using POS_Terminal;

namespace POS_Test
{
    public class ProductTest
    {

        //--------------------------------------------------------------------------------
        //---------------------------------- Product -------------------------------------
        //--------------------------------------------------------------------------------
        [Fact]
        public void Instantiation()
        {
            Product inv = new Product();
        }

        [Fact]
        public void AddProductTest()
        {
            //Arrange
            //Act
            //Assert
            Product product = new Product("Hamburger", "Food", "8000 calories", 17.99);
        }
    }
}
