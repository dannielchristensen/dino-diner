using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets{
        public  int numNugs = 6;
        public double price { get; set; }
        public uint calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "6 Nuggets" };
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.price = 4.25;
            this.calories = numNugs * 59;
        }

        //Adds a single nugget -- can be overriden to take a certain num of extra nugs
        public void addNugg()
        {
            this.numNugs++;
            this.price += .25;
            this.calories = numNugs * 59;
        }

        public void addNugg(int a)
        {
            this.numNugs += a;
            this.price += (.25 * a);
            this.calories = numNugs * 59;
        }
    }

}