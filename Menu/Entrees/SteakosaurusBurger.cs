/*  SteakosaurusBurger.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The SteakosaurusBurger objects extends the Entree abstract class
    /// </summary>
    public class SteakosaurusBurger : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Initializes the bool bun to true to show that there is a bun in a normal order
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Initializes the bool pickle to true to show that there is a pickle in a normal order
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Initializes the bool ketchup to true to show that there is a ketchup in a normal order
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Initializes the mustard bun to true to show that there is a mustard in a normal order
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// List containing the ingredients of the SteakosaurusBurger using bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> s = new List<string>() { "Steakburger Pattie" };
                if (bun) s.Add("Whole Wheat Bun");
                if (pickle) s.Add("Pickle");
                if (ketchup) s.Add("Ketchup");
                if (mustard) s.Add("Mustard");
                return s;
            }

        }
        /// <summary>
        /// Description of SteakosaurusBurger
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Creates list of special instructions for Steakosaurus Burgers
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!bun)
                    l.Add("Hold Bun");
                if (!ketchup)
                    l.Add("Hold Ketchup");
                if (!mustard)
                    l.Add("Hold Mustard");
                if (!pickle)
                    l.Add("Hold Pickle");
                return l.ToArray();

            }
        }
        /// <summary>
        /// Initializes the value of a SteakosaurusBurger and its price/calories to small
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// ToString for SteakosaurusBurger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// Sets bun to false to show that there is no bun
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Sets ketchup to false to show that there is no ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Sets pickle to false to show that there is no pickle
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Sets mustard to false to show that there is no mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }
    }
}