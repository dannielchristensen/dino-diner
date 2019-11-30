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
        public List<IOrderItem> Entree = new List<IOrderItem>();
        public List<IOrderItem> Side = new List<IOrderItem>();
        public List<IOrderItem> Combo = new List<IOrderItem>();
        public List<IOrderItem> Drink = new List<IOrderItem>();
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
                Entree = s.searchEntree(search);
                Combo = s.searchCombo(search);
                Side = s.searchSide(search);
                Drink = s.searchDrink(search);
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
                Entree = s.FilterByMinPrice(Entree, min);
                Combo = s.FilterByMinPrice(Combo, min);
                Side = s.FilterByMinPrice(Side, min);
                Drink = s.FilterByMinPrice(Drink, min);
            }

            if(maxPrice is float max)
            {
                Entree = s.FilterByMaxPrice(Entree, max);
                Combo = s.FilterByMaxPrice(Combo, max);
                Side = s.FilterByMaxPrice(Side, max);
                Drink = s.FilterByMaxPrice(Drink, max);
            }

            if(Ingredients.Count > 0)
            {
                Entree = s.FilterByIngredients(Entree, Ingredients);
                Combo = s.FilterByIngredients(Combo, Ingredients);
                Side = s.FilterByIngredients(Side, Ingredients);
                Drink = s.FilterByIngredients(Drink, Ingredients);
            }
        }
    }
}
