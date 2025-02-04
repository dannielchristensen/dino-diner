using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }
        [Fact]
        public void CorrectDescription()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(trex.ToString(), trex.Description);

        }
        [Fact]
        public void CorrectSpecial()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldMayo();
            trex.HoldMustard();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldTomato();
            Assert.Contains("Hold Bun", trex.Special);
            Assert.Contains("Hold Ketchup", trex.Special);
            Assert.Contains("Hold Lettuce", trex.Special);
            Assert.Contains("Hold Mayo", trex.Special);
            Assert.Contains("Hold Mustard", trex.Special);
            Assert.Contains("Hold Onion", trex.Special);
            Assert.Contains("Hold Pickle", trex.Special);
            Assert.Contains("Hold Tomato", trex.Special);


        }

        [Fact]
        public void CorrectSpecial6Hold()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldLettuce();
            trex.HoldMayo();
            trex.HoldOnion();
            trex.HoldPickle();
            trex.HoldTomato();
            Assert.Contains("Hold Bun", trex.Special);
            Assert.Contains("Hold Lettuce", trex.Special);
            Assert.Contains("Hold Mayo", trex.Special);
            Assert.Contains("Hold Onion", trex.Special);
            Assert.Contains("Hold Pickle", trex.Special);
            Assert.Contains("Hold Tomato", trex.Special);


        }
        [Fact]
        public void CorrectSpecial2Hold()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            trex.HoldBun();
            
            Assert.Contains("Hold Bun", trex.Special);
            Assert.Contains("Hold Ketchup", trex.Special);
            


        }
        [Fact]
        public void CorrectSpecial4Hold()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            trex.HoldLettuce();
            trex.HoldMustard();
            trex.HoldTomato();
            Assert.Contains("Hold Ketchup", trex.Special);
            Assert.Contains("Hold Lettuce", trex.Special);
            Assert.Contains("Hold Mustard", trex.Special);
            Assert.Contains("Hold Tomato", trex.Special);


        }
        [Fact]
        public void CorrectToString()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.ToString());

        }

        [Fact]
        public void shouldHaveEmptySpecialByDefault()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Empty(trex.Special);
        }
        [Fact]
        public void holdBunNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldBun();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldBun();
            }
            );

        }

        [Fact]
        public void holdMustardNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMustard();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldMustard();
            }
            );

        }

        [Fact]
        public void holdKetchupNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldKetchup();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldKetchup();
            }
            );

        }

        [Fact]
        public void holdPickleNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldPickle();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldPickle();
            }
            );

        }

        //  lettuce mayo onion tomato
        [Fact]
        public void holdLettuceNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldLettuce();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldLettuce();
            }
            );

        }

        [Fact]
        public void holdMayoNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldMayo();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldMayo();
            }
            );

        }

        [Fact]
        public void holdOnionNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldOnion();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldOnion();
            }
            );

        }

        [Fact]
        public void holdTomatoNotifies()
        {

            TRexKingBurger sb = new TRexKingBurger();
            Assert.PropertyChanged(sb, "Special", () =>
            {
                sb.HoldTomato();
            }
           );

            Assert.PropertyChanged(sb, "Ingredients", () =>
            {
                sb.HoldTomato();
            }
            );

        }




    }

}
