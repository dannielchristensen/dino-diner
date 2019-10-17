/*  MezzorellaSticks.cs
*  Author: Danniel Christensen
*/

using System.Collections.Generic;


namespace DinoDiner.Menu
{
    /// <summary>
    /// The MezzorellaSticks objects extends the Side abstract class
    /// </summary>
    public class MezzorellaSticks : Sides, IMenuItem, IOrderItem
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
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override List<string> Special
        {
            get
            {
                List<string> l = new List<string>();
                return l;
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

        public override string ToString()
        {
            return size.ToString() + " Mezzorella Sticks";
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