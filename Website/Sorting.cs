using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Menu;

namespace Website
{
    public class Sorting
    {
        private Menu menu = new Menu();
        public List<IOrderItem> Entree = new List<IOrderItem>();
        public List<IOrderItem> Side = new List<IOrderItem>();
        public List<IOrderItem> Combo = new List<IOrderItem>();
        public List<IOrderItem> Drink = new List<IOrderItem>();

        public List<string> MenuSection { get; set; } = new List<string>();

        public float? minPrice { get; set; }
        public float? maxPrice { get; set; }

        public Sorting()
        {
            Entree = menu.AvailableEntrees;
            Side = menu.AvailableSides;
            Combo = menu.AvailableCombos;
            Drink = menu.AvailableDrinks;

        }

        public List<IOrderItem> searchEntree(string term)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem d in Entree)
            {
                if (d.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(d);
                }
            }
            return results;
        }

        public List<IOrderItem> searchSide(string term)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem d in Side)
            {
                if (d.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(d);
                }
            }
            return results;
        }

        public List<IOrderItem> searchCombo(string term)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem d in Combo)
            {
                if (d.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(d);
                }
            }
            return results;
        }

        public List<IOrderItem> searchDrink(string term)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem d in Drink)
            {
                if(d.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(d);
                }
            }
            return results;
        }

        public List<IOrderItem> FilterByMinPrice(List<IOrderItem> currentList, float min)
        {
            List<IOrderItem> result = new List<IOrderItem>();
            foreach(IOrderItem i in currentList)
            {
                if (i.Price >= min)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public List<IOrderItem> FilterByMaxPrice(List<IOrderItem> currentList, float max)
        {
            List<IOrderItem> result = new List<IOrderItem>();
            foreach (IOrderItem i in currentList)
            {
                if (i.Price <= max)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public List<IOrderItem> FilterByIngredients(List<IOrderItem> currentList, List<string> exclude)
        {
            List<IOrderItem> result = new List<IOrderItem>();
            foreach(IOrderItem i in currentList)
            {
                bool canAdd = true;
                foreach(string e in exclude)
                {
                    if (i.Ingredients.Contains(e))
                    {
                        canAdd = false;
                        break;
                    }
                }
                if (canAdd)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
