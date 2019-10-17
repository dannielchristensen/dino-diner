﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PterodactylWingsUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal(7.21, pw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal<uint>(318, pw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PterodactylWings pw = new PterodactylWings();
            List<string> ingredients = pw.Ingredients;
            Assert.Contains<string>("Chicken", ingredients);
            Assert.Contains<string>("Wing Sauce", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
        [Fact]
        public void CorrectDescription()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal(pw.ToString(), pw.Description);

        }
        [Fact]
        public void CorrectSpecial()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.True(pw.Special.Count == 0);

        }

        [Fact]
        public void CorrectToString()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.ToString());

        }

    }
}
