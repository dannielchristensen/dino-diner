using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void CorrectDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(.1, w.Price);

        }

        [Fact]
        public void CorrectDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);

        }

        [Fact]
        public void CorrectDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);

        }
        [Fact]
        public void CorrectDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);

        }

        public void CorrectDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        [Fact]
        public void CorrectPriceAfterChangingToSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<double>(.1, w.Price);

        }

        [Fact]
        public void CorrectCaloriesAfterChangingToSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);

        }

        [Fact]
        public void CorrectPriceAfterChangingToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(.1, w.Price);

        }

        [Fact]
        public void CorrecCaloriesAfterChangingToMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);

        }

        [Fact]
        public void CorrectPriceAfterChangingToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(.1, w.Price);

        }

        [Fact]
        public void CorrecCaloriesAfterChangingToLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);

        }
        [Fact]
        public void HoldIceWorks()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        [Fact]
        public void AddLemonWorks()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }
        [Fact]
        public void CorrectIngredients()
        {
            Water w = new Water();
            Assert.Contains("Water", w.Ingredients);
        }
    }
}
