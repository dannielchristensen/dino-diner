using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void CorrectDescription()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(bw.ToString(), bw.Description);

        }
        [Fact]
        public void CorrectSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldOnion();
            bw.HoldPeppers();

            Assert.Contains("Hold Bun", bw.Special);
            Assert.Contains("Hold Onions", bw.Special);
            Assert.Contains("Hold Peppers", bw.Special);

        }

        [Fact]
        public void CorrectToString()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.ToString());

        }
        [Fact]
        public void shouldHaveEmptySpecialByDefault()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);
        }
        [Fact]
        public void holdBunNotifies()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldBun();
            }
            );

            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldBun();
            }
            );
        }
        [Fact]
        public void holdOnionNotifies()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldOnion();
            }
            );

            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldOnion();
            }
            );

        }
        [Fact]
        public void holdPeppersNotifies()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special", () =>
            {
                bw.HoldPeppers();
            }
            );

            Assert.PropertyChanged(bw, "Ingredients", () =>
            {
                bw.HoldPeppers();
            }
            );
        }
    }

}
