using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Menu class containing lists of all stuff on the menu
    /// Also seperated by type
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// list off Menu items
        /// </summary>
        public List<IOrderItem> AvailableMenuItem { get; } = new List<IOrderItem>();
        /// <summary>
        /// List of entrees items
        /// </summary>
        public List<IOrderItem> AvailableEntrees { get; } = new List<IOrderItem>();
        /// <summary>
        /// List of side items
        /// </summary>
        public List<IOrderItem> AvailableSides { get; } = new List<IOrderItem>();
        /// <summary>
        /// List of drink items
        /// </summary>
        public List<IOrderItem> AvailableDrinks { get; } = new List<IOrderItem>();
        /// <summary>
        /// List of combo items
        /// </summary>
        public List<IOrderItem> AvailableCombos { get; } = new List<IOrderItem>();

        /// <summary>
        /// creates an instance of menu
        /// </summary>
        public Menu()
        {
            AvailableMenuItem.Add(new JurassicJava());
            AvailableMenuItem.Add(new Sodasaurus());
            AvailableMenuItem.Add(new Tyrannotea());
            AvailableMenuItem.Add(new Water());

            AvailableDrinks.Add(new JurassicJava());
            AvailableDrinks.Add(new Sodasaurus());
            AvailableDrinks.Add(new Tyrannotea());
            AvailableDrinks.Add(new Water());

            AvailableMenuItem.Add(new Brontowurst());
            AvailableMenuItem.Add(new DinoNuggets());
            AvailableMenuItem.Add(new Tyrannotea());
            AvailableMenuItem.Add(new PrehistoricPBJ());
            AvailableMenuItem.Add(new PterodactylWings());
            AvailableMenuItem.Add(new SteakosaurusBurger());
            AvailableMenuItem.Add(new TRexKingBurger());
            AvailableMenuItem.Add(new VelociWrap());

            AvailableEntrees.Add(new Brontowurst());
            AvailableEntrees.Add(new DinoNuggets());
            AvailableEntrees.Add(new PrehistoricPBJ());
            AvailableEntrees.Add(new PterodactylWings());
            AvailableEntrees.Add(new SteakosaurusBurger());
            AvailableEntrees.Add(new TRexKingBurger());
            AvailableEntrees.Add(new VelociWrap());

            AvailableMenuItem.Add(new Fryceritops());
            AvailableMenuItem.Add(new MeteorMacAndCheese());
            AvailableMenuItem.Add(new MezzorellaSticks());
            AvailableMenuItem.Add(new Triceritots());

            AvailableSides.Add(new Fryceritops());
            AvailableSides.Add(new MeteorMacAndCheese());
            AvailableSides.Add(new MezzorellaSticks());
            AvailableSides.Add(new Triceritots());

            AvailableMenuItem.Add(new CretaceousCombo(new Brontowurst()));
            AvailableMenuItem.Add(new CretaceousCombo(new DinoNuggets()));
            AvailableMenuItem.Add(new CretaceousCombo(new PrehistoricPBJ()));
            AvailableMenuItem.Add(new CretaceousCombo(new PterodactylWings()));
            AvailableMenuItem.Add(new CretaceousCombo(new SteakosaurusBurger()));
            AvailableMenuItem.Add(new CretaceousCombo(new TRexKingBurger()));
            AvailableMenuItem.Add(new CretaceousCombo(new VelociWrap()));

            AvailableCombos.Add(new CretaceousCombo(new Brontowurst()));
            AvailableCombos.Add(new CretaceousCombo(new DinoNuggets()));
            AvailableCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
            AvailableCombos.Add(new CretaceousCombo(new PterodactylWings()));
            AvailableCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
            AvailableCombos.Add(new CretaceousCombo(new TRexKingBurger()));
            AvailableCombos.Add(new CretaceousCombo(new VelociWrap()));
        }

        /// <summary>
        /// ToString for available
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(IOrderItem i in AvailableMenuItem)
            {
                sb.Append(i.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
