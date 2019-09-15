using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets{
        public  int numNugs = 6;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for (int i = 0; i< 6; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                 
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = (uint) numNugs * 59;
        }

        //Adds a single nugget -- can be overriden to take a certain num of extra nugs
        public void AddNugget()
        {
            this.Ingredients.Add("Chicken Nugget");
            this.numNugs++;
            this.Price += .25;
            this.Calories = (uint) numNugs * 59;
        }

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