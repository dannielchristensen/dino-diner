/*  MezzorellaSticks.cs
*  Author: Danniel Christensen
*/

using System.Collections.Generic;


namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The MezzorellaSticks objects extends the Side abstract class
    /// </summary>
    public class MezzorellaSticks : Side
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }
        /// <summary>
        /// Constructor for MezzorellaSticks. Sets default Calories and Price to size small.
        /// </summary>
        public MezzorellaSticks()
        {
            base.Calories = 540;
            base.Price = 0.99;


        }

        /// <summary>
        /// Creates the list Ingredients for MezzorellaSticks 
        /// Overrides Ingredients in side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Breading", "Cheese Product", "Vegetable Oil" };

            }
        }
    }
}