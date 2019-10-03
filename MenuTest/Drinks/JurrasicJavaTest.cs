using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;


namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void CorrectDefaultPrice()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<double>(.59, j.Price);

        }
        [Fact]
        public void CorrectPriceAfterChangingToSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<double>(.59, j.Price);
        }
        [Fact]
        public void CorrectPriceAfterChangingToMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<double>(.99, j.Price);
        }
        [Fact]
        public void CorrectPriceAfterChangingToLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<double>(1.49, j.Price);
        }

        [Fact]
        public void CorrectDefaultCalories()
        {
            JurassicJava j = new JurassicJava();
            Assert.Equal<uint>(2, j.Calories);

        }
        [Fact]
        public void CorrectCaloriesAfterChangingToSmall()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            j.Size = Size.Small;
            Assert.Equal<uint>(2, j.Calories);
        }
        [Fact]
        public void CorrectCaloriesAfterChangingToMedium()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Medium;
            Assert.Equal<uint>(4, j.Calories);
        }
        [Fact]
        public void CorrectCaloriesAfterChangingToLarge()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            Assert.Equal<uint>(8, j.Calories);
        }

        [Fact]
        public void CorrectSpaceForCream()
        {
            JurassicJava j = new JurassicJava();
            Assert.False(j.RoomForCream);
        }

        [Fact]
        public void CorrectSpaceForCreamAfterAddingSpace()
        {
            JurassicJava j = new JurassicJava();
            j.LeaveRoomForCream();
            Assert.True(j.RoomForCream);
        }
        [Fact]
        public void CorrectIngredients()
        {
            JurassicJava j = new JurassicJava();
            Assert.Contains("Water", j.Ingredients);
            Assert.Contains("Coffee", j.Ingredients);
        }
    }
}
