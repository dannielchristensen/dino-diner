/*  Triceritots.cs
*  Author: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The Fryceritops objects extends the Side abstract class
    /// </summary>
    public class Triceritots: Sides, IMenuItem
    {
        /// <summary>
        /// Creates Size object to hold size of object
        /// </summary>
        private Size size;

        /// <summary>
        /// Allws access to size via getter and setter
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// Constructor for Triceritots. Sets default Calories and Price to size small.
        /// </summary>
        public Triceritots()
        {
            base.Calories = 352;
            base.Price = 0.99;


        }

        public override string ToString()
        {
            return size.ToString() + " Triceritots";
        }

        /// <summary>
        /// Creates the list Ingredients for Triceritots 
        /// Overrides Ingredients in side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Potato", "Salt", "Vegetable Oil" };

            }
        }
    }
}
