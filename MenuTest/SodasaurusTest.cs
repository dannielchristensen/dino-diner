using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest
{
    class SodasaurusTest
    {
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Sodasaurus s = new Sodasaurus();
            Assert.Equal<uint>(112, s.Calories);

        }
        //The correct default Calories
        // The correct default price
        //the correct default ice
        // the correct default size

        //correct calories after setting to small
        //correct price after setting small

        //After setting medium

        //After setting large
    }
}
