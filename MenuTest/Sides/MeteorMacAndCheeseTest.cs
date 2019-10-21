using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MeteorMacAndCheeseTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal(0.99, mmc.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, mmc.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", mmc.Ingredients);
            Assert.Contains<string>("Cheese Product", mmc.Ingredients);
            Assert.Contains<string>("Pork Sausage", mmc.Ingredients);
            Assert.Equal<int>(3, mmc.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal(1.45, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<uint>(490, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal(1.95, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<uint>(520, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mmc.Size);
        }
        public void CorrectDescription()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal(mmc.ToString(), mmc.Description);

        }
        [Fact]
        public void CorrectSpecial()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.True(mmc.Special.Length == 0);

        }

        [Fact]
        public void CorrectToString()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal(mmc.Size.ToString() + " Meteor Mac And Cheese", mmc.ToString());

        }

        [Fact]
        public void shouldHaveEmptySpecialByDefault()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Empty(mmc.Special);

        }

            [Fact]
        public void SizeChangeNotifiesAll()
        {
            MeteorMacAndCheese j = new MeteorMacAndCheese();
            j.Size = Size.Large;

            Assert.PropertyChanged(j, "Size", () =>
            {
                j.Size = Size.Medium;
            }
            );
            j.Size = Size.Large;

            Assert.PropertyChanged(j, "Price", () =>
            {
                j.Size = Size.Small;
            }
            );
            j.Size = Size.Medium;

            Assert.PropertyChanged(j, "Calories", () =>
            {
                j.Size = Size.Large;
            }
            );
        }
    }
}
