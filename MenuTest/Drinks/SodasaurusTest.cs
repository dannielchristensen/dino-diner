using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest
{
    public class SodasaurusTest
    {
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<uint>(112, s.Calories);
            
        }
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<double>(1.50, s.Price);
        }

        [Fact]
        public void HasCorrectDefaultIce()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.True(s.Ice);
        }
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal(Size.Small, s.Size);
        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToSmall()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            s.Size = Size.Small;
            Assert.Equal<uint>(112, s.Calories);

        }

        [Fact]
        public void HasCorrectPriceAfterSettingToSmall()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            s.Size = Size.Small;
            Assert.Equal<double>(1.5, s.Price);

        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToMedium()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal<uint>(156, s.Calories);

        }
        [Fact]
        public void HasCorrectPriceAfterSettingToMedium()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Medium;
            Assert.Equal<double>(2, s.Price);

        }
        [Fact]
        public void HasCorrectPriceAfterSettingToLarge()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<double>(2.5, s.Price);

        }
        [Fact]
        public void HasCorrectCaloriesAfterSettingToLarge()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            Assert.Equal<uint>(208, s.Calories);

        }
        [Fact]
        public void HasCorrectIngredients()
        {
            Sodasaurus s = new Sodasaurus();
            List<string> i = new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
            Assert.Equal<List<string>>(s.Ingredients, i);
        }
        [Fact]
        public void CanHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.holdIce();
            Assert.False(s.Ice);
        }
        [Fact]
        public void CanChangeFlavorToCola()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToCola();
            Assert.Equal<Flavors>(Flavors.Cola, s.flavor);

        }
        [Fact]
        public void CanChangeFlavorToCherry()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToCherry();
            Assert.Equal<Flavors>(Flavors.Cherry, s.flavor);

        }
        [Fact]
        public void CanChangeFlavorToChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToChocolate();
            Assert.Equal<Flavors>(Flavors.Chocolate, s.flavor);

        }
        [Fact]
        public void CanChangeFlavorToGrape()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToGrape();
            Assert.Equal<Flavors>(Flavors.Grape, s.flavor);

        }
        [Fact]
        public void CanChangeFlavorToLime()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToLime();
            Assert.Equal<Flavors>(Flavors.Lime, s.flavor);

        }
        [Fact]
        public void CanChangeFlavorToOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToOrange();
            Assert.Equal<Flavors>(Flavors.Orange, s.flavor);

        }
        [Fact]
        public void CanChangeFlavorToRootBeer()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToRootBeer();
            Assert.Equal<Flavors>(Flavors.RootBeer, s.flavor);

        }
        [Fact]
        public void CanChangeFlavorToVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToVanilla();
            Assert.Equal<Flavors>(Flavors.Vanilla, s.flavor);

        }
    }
}
