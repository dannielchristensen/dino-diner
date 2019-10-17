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
        [Fact]
        public void CorrectToString()
        { 
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            string test = j.Size.ToString() + " Jurassic Java";
            Assert.Equal(test, j.ToString());

            test = j.Size.ToString() + " Decaf Jurassic Java";
            j.MakeDecaf();
            Assert.Equal(test, j.ToString());

        }
        [Fact]
        public void CorrectDescription()
        {
            JurassicJava j = new JurassicJava();
            j.Size = Size.Large;
            string test = j.ToString();
            Assert.Equal(test, j.Description);
            j.MakeDecaf();
            test = j.ToString();
            Assert.Equal(test, j.Description);
        }

        [Fact]
        public void CorrectSpecial()
        {
            JurassicJava j = new JurassicJava();
            j.MakeDecaf();
            j.AddIce();
            j.LeaveRoomForCream();

            Assert.Contains("Add Ice", j.Special);
            Assert.Contains( "Make Decaf", j.Special);
            Assert.Contains("Leave room for Cream", j.Special);
        }
    }
}
