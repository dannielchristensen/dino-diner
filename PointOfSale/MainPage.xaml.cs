/* MainPage.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        /// <summary>
        /// creates main page
        /// </summary>
        public Page1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// controls Entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entrees_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("EntreeSelection.xaml", UriKind.Relative));
            
        }
        /// <summary>
        /// Controls Combo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Combo_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ComboSelection.xaml", UriKind.Relative));

        }
        /// <summary>
        /// Controls drinks button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drinks_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("DrinkSelection.xaml", UriKind.Relative));

        }
        /// <summary>
        /// Controls Sides button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sides_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SideSelection.xaml", UriKind.Relative));
        }
    }
}
