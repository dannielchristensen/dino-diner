/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// creates screen for combo selection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// changes screen to customzie combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Brontowurst_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new Brontowurst();
                order.Items.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("ComboEntreeScreen/Brontowurst.xaml", UriKind.Relative));

            }
        }
        /// <summary>
        /// changes screen to customzie combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggets_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new DinoNuggets();
                order.Items.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("ComboEntreeScreen/DinoNuggets.xaml", UriKind.Relative));

            }
        }
        /// <summary>
        /// changes screen to customzie combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrehistoricPBandJ_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new PrehistoricPBJ();
                order.Items.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("ComboEntreeScreen/PrehistoricPBJ.xaml", UriKind.Relative));

            }
        }
        /// <summary>
        /// changes screen to customzie combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PterodactylWings_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new PterodactylWings();
                order.Items.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));

            }
        }
        /// <summary>
        /// changes screen to customzie combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteakosaurusBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new SteakosaurusBurger();
                order.Items.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("ComboEntreeScreen/SteakosaurusBurger.xaml", UriKind.Relative));

            }
        }

        private void TRexKingBurger_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new TRexKingBurger();
                order.Items.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("ComboEntreeScreen/TRexKingBurger.xaml", UriKind.Relative));

            }
        }
        /// <summary>
        /// changes screen to customzie combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociWrap_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoDiner.Menu.Entree entree = new VelociWrap();
                order.Items.Add(new CretaceousCombo(entree));
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                this.NavigationService.Navigate(new Uri("ComboEntreeScreen/VelociWrap.xaml", UriKind.Relative));

            }
        }
    }
}
