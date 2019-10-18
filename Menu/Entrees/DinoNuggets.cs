/*  DinoNugget.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The DinoNuggets objects extends the Entree abstract class
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The numbers of nuggets in the order
        /// </summary>
        public  int numNugs = 6;

        
        /// <summary>
        /// Allws access to Price via getter and setter
        /// </summary>
        public override double Price { get; set; }

        /// <summary>
        /// Allws access to Calories via getter and setter
        /// </summary>
        public override uint Calories { get; set; }


        /// <summary>
        /// List containing the ingredients of the DinoNuggets using bools
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i< numNugs; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                 
                return ingredients;
            }
            
        }

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();

                if (numNugs != 6)
                {
                    l.Add($"{numNugs-6} Extra Nuggets");
                }

                return l.ToArray();

            }
        }
        /// <summary>
        /// Initializes the value of a DinoNuggets to six (6) nuggets and calculates calories off number of nuggets
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (uint) numNugs * 59;

        }

        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Adds one nugget to an order of DinoNuggets
        /// </summary>
        public void AddNugget()
        {
            this.numNugs++;
            this.Price += .25;
            this.Calories = (uint) numNugs * 59;
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// Adds a determined amount (a) nugget to an order of DinoNuggets
        /// </summary>
        /// <param name="a">amount of DinoNuggets to add</param>
        public void AddNugget(int a)
        {
            for(int i = 0; i< a; i++)
            {
                this.Ingredients.Add("Chicken Nugget");
            }
            this.numNugs += a;
            this.Price += (.25 * a);
            this.Calories = (uint) numNugs * 59;
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
        }
    }

}