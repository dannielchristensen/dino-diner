﻿using System;
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

        [Fact]
        public void CorrectToString()
        {
            Water w = new Water();
            w.Size = Size.Large;
            string test = w.Size.ToString() + " Water";
            Assert.Equal(test, w.ToString());
           

        }
        [Fact]
        public void CorrectDescription()
        {
            Water w = new Water();
            w.Size = Size.Large;
            string test = w.Size.ToString() + " Water";
            Assert.Equal(test, w.Description);
        }
        [Fact]
        public void CorrectSpecial()
        {
            Water w = new Water();
            w.HoldIce();
            w.AddLemon();
            Assert.Contains("Hold Ice", w.Special);
            Assert.Contains("Add Lemon", w.Special);

        }
        [Fact]
        public void shouldHaveEmptySpecialByDefault()
        {
            Water w = new Water();
            Assert.Empty(w.Special);
        }

        [Fact]
        public void HoldIceNotifies()
        {
            Water s = new Water();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldIce();
            }
            );
        }

        [Fact]
        public void AddLemonNotifies()
        {
            Water s = new Water();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldIce();
            }
            );

            

        }
    }
}

