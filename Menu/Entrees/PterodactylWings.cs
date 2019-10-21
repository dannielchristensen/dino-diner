/*  PterodactylWings.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The PterodactylWings objects extends the Entree abstract class
    /// </summary>
    public class PterodactylWings : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Description for wings
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special instructions for wings
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();

                return l.ToArray();

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
        /// <summary>
        /// ToString for wings
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}