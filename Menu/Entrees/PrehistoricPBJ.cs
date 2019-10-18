/*  PrehistoricPBJ.cs
 *  Author: Nathan Bean
 *  Modified by: Danniel Christensen
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The PrehistoricPBJ objects extends the Entree abstract class
    /// </summary>
    public class PrehistoricPBJ : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Initializes the bool peanutButter to true to show that there is a peanutButter in a normal order
        /// </summary>
        private bool peanutButter = true;

        /// <summary>
        /// Initializes the bool jelly to true to show that there is a jelly in a normal order
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// Allws access to Price via getter and setter
        /// </summary>
        public override double Price { get; set; }

        /// <summary>
        /// Allws access to Calories via getter and setter
        /// </summary>
        public override uint Calories { get; set; }

        /// <summary>
        /// List containing the ingredients of the PrehistoricPBJ using bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Descritpion for PBJ
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special for PBJ
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!peanutButter)
                    l.Add("Hold Peanut Butter");
                if (!jelly)
                    l.Add("Hold Jelly");
               
                return l.ToArray();

            }
        }
        /// <summary>
        /// Initializes the value of a PrehistoricPBJ and its price/calories to small
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }
        /// <summary>
        /// ToString for PBJ
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// Sets peanutButter to false to show that there is no peanutButter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
            NotifyOfPropertyChanged("peanutButter");
        }

        /// <summary>
        /// Sets jelly to false to show that there is no jelly
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
            NotifyOfPropertyChanged("jelly");
        }
    }
}
