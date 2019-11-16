/* FlavorSelection.xaml.cs
*   Author: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale.ComboDrinkSideScreen
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// creates Flavor Selection screen
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }
        public void cherryFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.Sodasaurus s)
                    {
                        s.Flavor = SodasaurusFlavor.Cherry;
                        CollectionViewSource.GetDefaultView(order.Items).Refresh();
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.DrinkSelection());
                    }
                }
            }

        }

        public void chocFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.Sodasaurus s)
                    {
                        s.Flavor = SodasaurusFlavor.Chocolate;
                        CollectionViewSource.GetDefaultView(order.Items).Refresh();
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.DrinkSelection());
                    }
                }
            }

        }

        public void colaFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.Sodasaurus s)
                    {
                        s.Flavor = SodasaurusFlavor.Cola;
                        CollectionViewSource.GetDefaultView(order.Items).Refresh();
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.DrinkSelection());
                    }
                }
            }

        }

        public void limeFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.Sodasaurus s)
                    {
                        s.Flavor = SodasaurusFlavor.Lime;
                        CollectionViewSource.GetDefaultView(order.Items).Refresh();
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.DrinkSelection());
                    }
                }
            }

        }

        public void orangeFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.Sodasaurus s)
                    {
                        s.Flavor = SodasaurusFlavor.Orange;
                        CollectionViewSource.GetDefaultView(order.Items).Refresh();
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.DrinkSelection());
                    }
                }
            }

        }

        public void rootbeerFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.Sodasaurus s)
                    {
                        s.Flavor = SodasaurusFlavor.RootBeer;
                        CollectionViewSource.GetDefaultView(order.Items).Refresh();
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.DrinkSelection());
                    }
                }
            }

        }

        public void vanillaFlavor(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.Sodasaurus s)
                    {
                        s.Flavor = SodasaurusFlavor.Vanilla;
                        CollectionViewSource.GetDefaultView(order.Items).Refresh();
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.DrinkSelection());
                    }
                }
            }

        }
    }
}
