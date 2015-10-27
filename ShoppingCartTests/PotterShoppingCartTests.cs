using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod()]
        public void AddToCardTest_vol1_1_total_should_be_100()
        {
            // Arrange
            PotterBook vol1 = new PotterBook { Volumn = 1 };
            var target = new PotterShoppingCart();
            var expected = 100;

            // Action
            target.AddToCard(vol1,1);

            // Assert
            Assert.AreEqual(expected,target.getTotal());
        }

        [TestMethod()]
        public void AddToCardTest_vol1_1_vol2_1_total_should_be_190()
        {
            // Arrange
            PotterBook vol1 = new PotterBook { Volumn = 1 };
            PotterBook vol2 = new PotterBook { Volumn = 2 };
            var target = new PotterShoppingCart();
            var expected = 190;

            // Action
            target.AddToCard(vol1,1);
            target.AddToCard(vol2,1);

            // Assert
            Assert.AreEqual(expected, target.getTotal());
        }

        [TestMethod()]
        public void AddToCardTest_vol1_1_vol2_1_vol3_1_total_should_be_270()
        {
            // Arrange
            PotterBook vol1 = new PotterBook { Volumn = 1 };
            PotterBook vol2 = new PotterBook { Volumn = 2 };
            PotterBook vol3 = new PotterBook { Volumn = 3 };
            var target = new PotterShoppingCart();
            var expected = 270;

            // Action
            target.AddToCard(vol1,1);
            target.AddToCard(vol2,1);
            target.AddToCard(vol3,1);

            // Assert
            Assert.AreEqual(expected, target.getTotal());
        }

        [TestMethod()]
        public void AddToCardTest_vol1_1_vol2_1_vol3_1_vol4_1_total_should_be_320()
        {
            // Arrange
            PotterBook vol1 = new PotterBook { Volumn = 1 };
            PotterBook vol2 = new PotterBook { Volumn = 2 };
            PotterBook vol4 = new PotterBook { Volumn = 4 };
            PotterBook vol3 = new PotterBook { Volumn = 3 };
            var target = new PotterShoppingCart();
            var expected = 320;

            // Action
            target.AddToCard(vol1,1);
            target.AddToCard(vol2,1);
            target.AddToCard(vol3,1);
            target.AddToCard(vol4,1);
            // Assert
            Assert.AreEqual(expected, target.getTotal());
        }

        [TestMethod()]
        public void AddToCardTest_vol1_1_vol2_1_vol3_1_vol4_1_vol5_1_total_should_be_375()
        {
            // Arrange
            PotterBook vol1 = new PotterBook { Volumn = 1 };
            PotterBook vol2 = new PotterBook { Volumn = 2 };
            PotterBook vol3 = new PotterBook { Volumn = 3 };
            PotterBook vol4 = new PotterBook { Volumn = 4 };
            PotterBook vol5 = new PotterBook { Volumn = 5 };
            var target = new PotterShoppingCart();
            var expected = 375;

            // Action
            target.AddToCard(vol1,1);
            target.AddToCard(vol2,1);
            target.AddToCard(vol3, 1);
            target.AddToCard(vol4, 1);
            target.AddToCard(vol5, 1);

            // Assert
            Assert.AreEqual(expected, target.getTotal());
        }

        [TestMethod()]
        public void AddToCardTest_vol1_1_vol2_1_vol3_2_total_should_be_370()
        {
            // Arrange
            PotterBook vol1 = new PotterBook { Volumn = 1 };
            PotterBook vol2 = new PotterBook { Volumn = 2 };
            PotterBook vol3 = new PotterBook { Volumn = 3 };
            var target = new PotterShoppingCart();
            var expected = 370;

            // Action
            target.AddToCard(vol1,1);
            target.AddToCard(vol2,1);
            target.AddToCard(vol3, 2);

            // Assert
            Assert.AreEqual(expected, target.getTotal());
        }

        [TestMethod()]
        public void AddToCardTest_vol1_1_vol2_2_vol3_2_total_should_be_460()
        {
            // Arrange
            PotterBook vol1 = new PotterBook { Volumn = 1 };
            PotterBook vol2 = new PotterBook { Volumn = 2 };
            PotterBook vol3 = new PotterBook { Volumn = 3 };
            var target = new PotterShoppingCart();
            var expected = 460;

            // Action
            target.AddToCard(vol1, 1);
            target.AddToCard(vol2, 2);
            target.AddToCard(vol3, 2);

            // Assert
            Assert.AreEqual(expected, target.getTotal());
        }


    }
}