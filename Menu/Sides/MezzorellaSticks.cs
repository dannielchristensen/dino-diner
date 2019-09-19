using System.Collections.Generic;


namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
        }

        public MezzorellaSticks()
        {
            base.Calories = 540;
            base.Price = 0.99;


        }

        public List<string> Ingredients = new List<string> { "Breading","Cheese Product","Vegetable Oil"};
    }
}