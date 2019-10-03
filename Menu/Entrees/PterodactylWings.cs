/*  PterodactylWings.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The PterodactylWings objects extends the Entree abstract class
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem
    {
        /// <summary>
        /// Allws access to Price via getter and setter
        /// </summary>
        public override double Price { get; set; }

        /// <summary>
        /// Allws access to Calories via getter and setter
        /// </summary>
        public override uint Calories { get; set; }

        /// <summary>
        /// List containing the ingredients of the PterodactylWings using bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Initializes the value of a PterodactylWings and its price/calories to small
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}