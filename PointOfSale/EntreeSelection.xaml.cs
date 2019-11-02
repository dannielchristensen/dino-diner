/* EntreeSelection.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Entree.xaml
    /// </summary>
    public partial class Entree : Page
    {
        /// <summary>
        /// Creates Entree Screen
        /// </summary>
        public Entree()
        {
            InitializeComponent();
        }

        public void AddBrontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new Brontowurst();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("EntreeScreen/Brontowurst.xaml", UriKind.Relative));

            }

        }

        public void AddDinoNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new DinoNuggets();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("EntreeScreen/DinoNuggets.xaml", UriKind.Relative));

            }

        }

        public void AddPBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new PrehistoricPBJ();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("EntreeScreen/PrehistoricPBJ.xaml", UriKind.Relative));

            }

        }

        public void AddWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new PterodactylWings();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Page1());

            }

        }

        public void AddSteakBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new SteakosaurusBurger();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("EntreeScreen/SteakosaurusBurger.xaml", UriKind.Relative));

            }

        }

        public void AddKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new TRexKingBurger();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("EntreeScreen/TRexKingBurger.xaml", UriKind.Relative));

            }

        }

        public void AddVelociWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new VelociWrap();
                order.Items.Add(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("EntreeScreen/VelociWrap.xaml", UriKind.Relative));

            }

        }
        public void ReturnToMain(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}
