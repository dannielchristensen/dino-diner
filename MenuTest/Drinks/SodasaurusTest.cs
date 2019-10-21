using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

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
            List<string> i = new List<string> { "Water", "Natural SodasaurusFlavor", "Cane Sugar" };
            Assert.Equal<List<string>>(s.Ingredients, i);
        }
        [Fact]
        public void CanHoldIce()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.False(s.Ice);
        }
        [Fact]
        public void CanChangeFlavorToCola()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToCola();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, s.Flavor);

        }
        [Fact]
        public void CanChangeFlavorToCherry()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToCherry();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, s.Flavor);

        }
        [Fact]
        public void CanChangeFlavorToChocolate()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToChocolate();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, s.Flavor);

        }
        [Fact]
        public void CanChangeFlavorToGrape()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToGrape();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Grape, s.Flavor);

        }
        [Fact]
        public void CanChangeFlavorToLime()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToLime();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, s.Flavor);

        }
        [Fact]
        public void CanChangeFlavorToOrange()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToOrange();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, s.Flavor);

        }
        [Fact]
        public void CanChangeFlavorToRootBeer()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToRootBeer();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, s.Flavor);

        }
        [Fact]
        public void CanChangeFlavorToVanilla()
        {
            Sodasaurus s = new Sodasaurus();
            s.setFlavorToVanilla();
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, s.Flavor);

        }
        [Fact]
        public void CorrectToString()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            s.setFlavorToOrange();
            string test = s.Size.ToString() + " " + s.Flavor.ToString()+" Sodasaurus";
            Assert.Equal(test, s.ToString());

            s.setFlavorToCola();
            test = s.Size.ToString() + " " + s.Flavor.ToString() + " Sodasaurus";
            Assert.Equal(test, s.ToString());

            s.setFlavorToGrape();
            test = s.Size.ToString() + " " + s.Flavor.ToString() + " Sodasaurus";
            Assert.Equal(test, s.ToString());

            s.setFlavorToCherry();
            test = s.Size.ToString() + " " + s.Flavor.ToString() + " Sodasaurus";
            Assert.Equal(test, s.ToString());

            s.setFlavorToChocolate();
            test = s.Size.ToString() + " " + s.Flavor.ToString() + " Sodasaurus";
            Assert.Equal(test, s.ToString());

            s.setFlavorToLime();
            test = s.Size.ToString() + " " + s.Flavor.ToString() + " Sodasaurus";
            Assert.Equal(test, s.ToString());

            s.setFlavorToRootBeer();
            test = s.Size.ToString() + " " + s.Flavor.ToString() + " Sodasaurus";
            Assert.Equal(test, s.ToString());

            s.setFlavorToVanilla();
            test = s.Size.ToString() + " " + s.Flavor.ToString() + " Sodasaurus";
            Assert.Equal(test, s.ToString());
        }
        [Fact]
        public void CorrectDescription()
        {
            Sodasaurus s = new Sodasaurus();
            s.Size = Size.Large;
            s.setFlavorToOrange();
            string test = s.ToString();
            Assert.Equal(test, s.Description);

            s.setFlavorToCola();
            test = s.ToString();
            Assert.Equal(test, s.Description);

            s.setFlavorToGrape();
            test = s.ToString();
            Assert.Equal(test, s.Description);

            s.setFlavorToCherry();
            test = s.ToString();
            Assert.Equal(test, s.Description);

            s.setFlavorToChocolate();
            test = s.ToString();
            Assert.Equal(test, s.Description);

            s.setFlavorToLime();
            test = s.ToString();
            Assert.Equal(test, s.Description);

            s.setFlavorToRootBeer();
            test = s.ToString();
            Assert.Equal(test, s.Description);

            s.setFlavorToVanilla();
            test = s.ToString();
            Assert.Equal(test, s.Description);
        }
        [Fact]
        public void CorrectSpecial()
        {
            Sodasaurus s = new Sodasaurus();

            s.HoldIce();
            Assert.Contains("Hold Ice", s.Special);
        }

        [Fact]
        public void shouldHaveEmptySpecialByDefault()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Empty(s.Special);
        }
        [Fact]
        public void holdIceNotifies()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldIce();
            }
            );
        }


      

        [Fact]
        public void SizeChangeNotifiesAll()
        {
            Sodasaurus j = new Sodasaurus();
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

        [Fact]
        public void FlavorChangesNotifiesAll()
        {
            Sodasaurus s = new Sodasaurus();
            
            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToCherry();
            }
            );

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToChocolate();
            }
            );

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToCola();
            }
            );

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToGrape();
            }
            );

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToLime();
            }
            );

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToOrange();
            }
            );

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToRootBeer();
            }
            );

            Assert.PropertyChanged(s, "Flavor", () =>
            {
                s.setFlavorToVanilla();
            }
            );


        }
    }
}
