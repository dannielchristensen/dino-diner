using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{

    public class TyrannoteaTest
    {
        [Fact]
        public void hasCorrectDefaultLemon()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.False(s.Lemon);

        }
        
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal<uint>(8, s.Calories);

        }
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal<double>(.99, s.Price);
        }

        [Fact]
        public void HasCorrectDefaultIce()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.False(s.Ice);
        }
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Equal(Size.Small, s.Size);
        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToSmall()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;
            s.Size = Size.Small;
            s.MakeSweet();
            s.MakeUnSweet();
            Assert.Equal<uint>(8, s.Calories);

        }

        [Fact]
        public void HasCorrectPriceAfterSettingToSmall()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;
            s.Size = Size.Small;
            Assert.Equal<double>(.99, s.Price);

        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToMedium()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;
            s.MakeSweet();
            s.MakeUnSweet();
            Assert.Equal<uint>(16, s.Calories);

        }
        [Fact]
        public void HasCorrectPriceAfterSettingToMedium()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;

            Assert.Equal<double>(1.49, s.Price);

        }
        [Fact]
        public void HasCorrectPriceAfterSettingToLarge()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            Assert.Equal<double>(1.99, s.Price);

        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToLarge()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            s.MakeSweet();
            s.MakeUnSweet();
            Assert.Equal<uint>(32, s.Calories);

        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToSmallAndSweet()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Small;
            s.MakeSweet();
            Assert.Equal<uint>(16, s.Calories);

        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToMediumAndSweet()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Medium;
            s.MakeSweet();
            Assert.Equal<uint>(32, s.Calories);

        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToLargeAndSweet()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            s.MakeSweet();
            Assert.Equal<uint>(64, s.Calories);

        }
        [Fact]
        public void HasCorrectDefaultIngredients()
        {
            Tyrannotea s = new Tyrannotea();
            List<string> i = new List<string> { "Water", "Tea" };
            Assert.Equal<List<string>>(s.Ingredients, i);
        }
        [Fact]
        public void AddLemonContainsLemon()
        {
            Tyrannotea s = new Tyrannotea();
            s.AddLemon();
            Assert.True(s.Lemon);
            Assert.Contains<string>("Lemon", s.Ingredients);
        }
        [Fact]
        public void MakeSweetContainsSugar()
        {
            Tyrannotea s = new Tyrannotea();
            s.MakeSweet();
            Assert.True(s.Sweet);
            Assert.Contains<string>("Cane Sugar", s.Ingredients);
        }
        [Fact]
        public void CanHoldIce()
        {
            Tyrannotea s = new Tyrannotea();
            s.holdIce();
            Assert.False(s.Ice);
        }
       
    }
}
