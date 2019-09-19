using System.Collections.Generic;


namespace DinoDiner.Menu.Sides
{
    public class Fryceritops: Side
    {
        private Size size;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }
        public Fryceritops()
        {
            base.Calories = 222;
            base.Price = 0.99;


        }

        public List<string> Ingredients = new List<string>{ "Potato", "Salt", "Vegetable Oil" };

    }
}