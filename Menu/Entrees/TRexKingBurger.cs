/*  TRexKingBurger.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// The VelociWrap objects extends the Entree abstract class
    /// </summary>
    public class TRexKingBurger : Entree
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
        /// Initializes the bool mustard to true to show that there is a mustard in a normal order
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Initializes the bool lettuce to true to show that there is a lettuce in a normal order
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Initializes the bool Tomato to true to show that there is a Tomato in a normal order
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Initializes the bool Onion to true to show that there is a Onion in a normal order
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Initializes the bool Mayo to true to show that there is a Mayo in a normal order
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// List containing the ingredients of the TRexKingBurger using bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> s = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) s.Add("Whole Wheat Bun");
                if (pickle) s.Add("Pickle");
                if (ketchup) s.Add("Ketchup");
                if (mustard) s.Add("Mustard");
                if (onion) s.Add("Onion");
                if (mayo) s.Add("Mayo");
                if (lettuce) s.Add("Lettuce");
                if (tomato) s.Add("Tomato");

                return s;
            }

        }

        /// <summary>
        /// Initializes the value of a TRexKingBurger and its price/calories to small
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Sets bun to false to show that there is no bun
        /// </summary>
        public void HoldBun() => this.bun = false;

        /// <summary>
        /// Sets ketchup to false to show that there is no ketchup
        /// </summary>
        public void HoldKetchup() => this.ketchup = false;

        /// <summary>
        /// Sets pickle to false to show that there is no pickle
        /// </summary>
        public void HoldPickle() => this.pickle = false;

        /// <summary>
        /// Sets mustard to false to show that there is no mustard
        /// </summary>
        public void HoldMustard() => this.mustard = false;

        /// <summary>
        /// Sets lettuce to false to show that there is no lettuce
        /// </summary>
        public void HoldLettuce() => this.lettuce = false;

        /// <summary>
        /// Sets mayo to false to show that there is mayo bun
        /// </summary>
        public void HoldMayo() => this.mayo = false;

        /// <summary>
        /// Sets onion to false to show that there is no onion
        /// </summary>
        public void HoldOnion() => this.onion = false;

        /// <summary>
        /// Sets tomato to false to show that there is no tomato
        /// </summary>
        public void HoldTomato() => this.tomato = false;
    }

}