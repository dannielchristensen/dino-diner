using System.Collections.Generic;


namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }

        public MeteorMacAndCheese()
        {
            base.Calories = 420;
            base.Price = 0.99;


        }

        public List<string> Ingredients = new List<string> { "Macaroni Noodles", "Cheese Product","Pork Sausage"};
    }
}