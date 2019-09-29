using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;


namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        [Fact]
        public void CorrectDefaultPrice()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal<double>(.59, j.Price);

        }
        [Fact]
        public void CorrectPriceAfterChangingToSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);
        }
        [Fact]
        public void CorrectPriceAfterChangingToMedium()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(.99, j.Price);
        }
        [Fact]
        public void CorrectPriceAfterChangingToLarge()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }

        [Fact]
        public void CorrectDefaultCalories()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Equal<uint>(2, j.Calories);

        }
        [Fact]
        public void CorrectCaloriesAfterChangingToSmall()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<uint>(2, j.Calories);
        }
        [Fact]
        public void CorrectCaloriesAfterChangingToMedium()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Medium;
            Assert.Equal<uint>(4, j.Calories);
        }
        [Fact]
        public void CorrectCaloriesAfterChangingToLarge()
        {
            JurrasicJava j = new JurrasicJava();
            j.Size = Size.Large;
            Assert.Equal<uint>(8, j.Calories);
        }

        [Fact]
        public void CorrectSpaceForCream()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.False(j.RoomForCream);
        }

        [Fact]
        public void CorrectSpaceForCreamAfterAddingSpace()
        {
            JurrasicJava j = new JurrasicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }
        [Fact]
        public void CorrectIngredients()
        {
            JurrasicJava j = new JurrasicJava();
            Assert.Contains("Water", j.Ingredients);
            Assert.Contains("Coffee", j.Ingredients);
        }
    }
}
