/*  DinoNugget.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The DinoNuggets objects extends the Entree abstract class
    /// </summary>
    public class DinoNuggets : Entree, IMenuItem, IOrderItem
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

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public List<string> Special
        {
            get
            {
                List<string> l = new List<string>();
                l.Add($"Total Nugs: {numNugs}");

                return l;

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
        }
    }

}