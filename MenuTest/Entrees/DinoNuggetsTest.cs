using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class DinoNuggetsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal(4.25, dn.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal<uint>(59*6, dn.Calories);
        }


        [Fact]
        public void ShouldListDefaultIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            List<string> ingredients = dn.Ingredients;
            // Should be six nuggets
            int nuggetCount = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal(6, nuggetCount);
            Assert.Equal<int>(6, ingredients.Count);
        }

        [Fact]
        public void AddingNuggetsShouldAddIngredients()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            // Should be seven nuggets
            int nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(7, nuggetCount);
            Assert.Equal<int>(7, dn.Ingredients.Count);

            dn.AddNugget();
            // Should be 8 nuggets
            nuggetCount = 0;
            foreach (string ingredient in dn.Ingredients)
            {
                if (ingredient.Equals("Chicken Nugget")) nuggetCount++;
            }
            Assert.Equal<int>(8, nuggetCount);
            Assert.Equal<int>(8, dn.Ingredients.Count);

        }

        [Fact]
        public void AddingNuggetsShouldIncreasePrice()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal(dn.Price, 4.50, 2);
            dn.AddNugget();
            Assert.Equal(dn.Price, 4.75, 2);
            dn.AddNugget();
            Assert.Equal(dn.Price, 5.0, 2);
        }

        [Fact]
        public void AddingNuggetsShouldIncreaseCalories()
        {
            DinoNuggets dn = new DinoNuggets();
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*7);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*8);
            dn.AddNugget();
            Assert.Equal<uint>(dn.Calories, 59*9);
        }

        [Fact]
        public void CorrectDescription()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal(dn.ToString(), dn.Description);

        }
     

        [Fact]
        public void CorrectToString()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.ToString());

        }
        [Fact]
        public void shouldHaveEmptySpecialByDefault()
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.Empty(dn.Special);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(16)]
        public void ShouldHaveCorrectSpecialForNuggets(int extraNuggets)
        {
            DinoNuggets dn = new DinoNuggets();
            for (int i = 0; i < extraNuggets; i++) {
                dn.AddNugget();
            }
            Assert.Collection<string>(dn.Special, item =>
            {
                Assert.Equal($"{extraNuggets} Extra Nuggets", item);
            });
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Description")]
        [InlineData("Price")]
        [InlineData("Calories")]

        public void AddingNuggetsShouldNotifyOfPropertyChange(string propertyName)
        {
            DinoNuggets dn = new DinoNuggets();
            Assert.PropertyChanged(dn, propertyName, ()=>
            {
                dn.AddNugget();
            }
            );
        }
    }
}
