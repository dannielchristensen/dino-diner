/*  Brontowurst.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The Brontowurst objects extends the Entree abstract class
    /// </summary>
    public class Brontowurst : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes the bool bun to true to show that there is a bun in a normal order
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Initializes the bool peppers to true to show that there is a peppers in a normal order
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Initializes the bool onions to true to show that there is a onions in a normal order
        /// </summary>
        private bool onions = true;

        /// <summary>
        /// Allws access to Price via getter and setter
        /// </summary>
        public override double Price { get; set; }

        /// <summary>
        /// Allws access to Calories via getter and setter
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// Description for Brontowurst
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special for brontowurst
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!bun)
                    l.Add("Hold Bun");
                if (!peppers)
                    l.Add("Hold Peppers");
                if (!onions)
                    l.Add("Hold Onions");

                return l.ToArray();

            }
        }
        /// <summary>
        /// List containing the ingredients of the Brontowurst using bools
        /// </summary>

        public override List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>() { "Brautwurst" };
                if (bun) i.Add("Whole Wheat Bun");
                if (peppers) i.Add("Peppers");
                if (onions) i.Add("Onion");
                return i;
            }
        }

        /// <summary>
        /// Initializes the value of a Brontowurst and its price/calories to small
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// ToString for brontowurst
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

        /// <summary>
        /// Sets bun to false to show that there is no bun
        /// </summary>
        public void HoldBun() {
            this.bun = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Sets peppers to false to show that there is no peppers
        /// </summary>
        public void HoldPeppers() {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Sets onions to false to show that there is no onions
        /// </summary>
        public void HoldOnion() {
            this.onions = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");


        }

    }
}