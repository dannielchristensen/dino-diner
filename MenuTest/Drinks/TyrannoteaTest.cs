using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

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
            Assert.True(s.Ice);
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
            s.HoldIce();
            Assert.False(s.Ice);
        }

        [Fact]
        public void CorrectToString()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            string test = s.Size.ToString() + " Tyrannotea";
            Assert.Equal(test, s.ToString());
            s.MakeSweet();
            test = s.Size.ToString() + " Sweet Tyrannotea";
            Assert.Equal(test, s.ToString());

        }
        [Fact]
        public void CorrectDescription()
        {
            Tyrannotea s = new Tyrannotea();
            s.Size = Size.Large;
            string test = s.Size.ToString() + " Tyrannotea";
            Assert.Equal(test, s.Description);
            s.MakeSweet();
            test = s.Size.ToString() + " Sweet Tyrannotea";
            Assert.Equal(test, s.Description);
        }
        [Fact]
        public void CorrectSpecial()
        {
            Tyrannotea s = new Tyrannotea();

            s.HoldIce();
            s.AddLemon();
            Assert.Contains("Hold Ice", s.Special);
            Assert.Contains("Add Lemon", s.Special);

        }

        [Fact]
        public void shouldHaveEmptySpecialByDefault()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.Empty(s.Special);
        }

        [Fact]
        public void SizeChangeNotifiesAll()
        {
            Tyrannotea j = new Tyrannotea();
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
        public void holdIceNotifies()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.HoldIce();
            }
            );
        }

        [Fact]
        public void MakeSweetNotifies()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.MakeSweet();
            }
            );

           

            Assert.PropertyChanged(s, "Calories", () =>
            {
                s.MakeSweet();
            }
            );

            Assert.PropertyChanged(s, "Description", () =>
            {
                s.MakeSweet();
            }
            );
        }
       
        [Fact]
        public void AddLemonNotifies()
        {
            Tyrannotea s = new Tyrannotea();
            Assert.PropertyChanged(s, "Special", () =>
            {
                s.AddLemon();
            }
            );

            Assert.PropertyChanged(s, "Ingredients", () =>
            {
                s.AddLemon();
            }
            );
        }

    }






    }


