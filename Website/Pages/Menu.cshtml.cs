using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        private Menu menu = new Menu();
        public IEnumerable<IOrderItem> Entree = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Side = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Combo = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Drink = new List<IOrderItem>();
        public void OnGet()
        {
            Entree = menu.AvailableEntrees;
            Side = menu.AvailableSides;
            Combo = menu.AvailableCombos;
            Drink = menu.AvailableDrinks;

        }
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> MenuSection { get; set; } = new List<string>();
        [BindProperty]
        public float? minPrice { get; set; }
        [BindProperty]
        public float? maxPrice { get; set; }
        [BindProperty]
        public List<string> Ingredients { get; set; } = new List<string>();
        public void OnPost()
        {
            Sorting s = new Sorting();
            Entree = menu.AvailableEntrees;
            Side = menu.AvailableSides;
            Combo = menu.AvailableCombos;
            Drink = menu.AvailableDrinks;
            if (search != null)
            {
                Entree = Entree.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                Combo = Combo.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                Side = Side.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                Drink = Drink.Where(item => item.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (MenuSection.Count > 0)
            {
                if (!MenuSection.Contains("Entree"))
                {
                    Entree = new List<IOrderItem>();
                }

                if (!MenuSection.Contains("Combo"))
                {
                    Combo = new List<IOrderItem>();
                }

                if (!MenuSection.Contains("Side"))
                {
                    Side = new List<IOrderItem>();
                }

                if (!MenuSection.Contains("Drink"))
                {
                    Drink = new List<IOrderItem>();
                }

            }

            if(minPrice is float min)
            {
                Entree = Entree.Where(item => item.Price > min);
                Combo = Combo.Where(item => item.Price > min);
                Side = Side.Where(item => item.Price > min);
                Drink = Drink.Where(item => item.Price > min);
            }

            if(maxPrice is float max)
            {
                Entree = Entree.Where(item => item.Price < max);
                Combo = Combo.Where(item => item.Price < max);
                Side = Side.Where(item => item.Price < max);
                Drink = Drink.Where(item => item.Price < max);
            }

            if(Ingredients.Count > 0)
            {
                foreach(string i in Ingredients)
                {
                    Entree = Entree.Where(item => !item.Ingredients.Contains(i));
                    Combo = Combo.Where(item => !item.Ingredients.Contains(i));
                    Side = Side.Where(item => !item.Ingredients.Contains(i));
                    Drink = Drink.Where(item => !item.Ingredients.Contains(i));
                }
                
            }
        }
    }
}
