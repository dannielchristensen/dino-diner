/* CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// creates screen for customize combo
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// changes screen to side
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Side_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SideSelection.xaml", UriKind.Relative));

        }
        /// <summary>
        /// changes screen to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("DrinkSelection.xaml", UriKind.Relative));

        }

       
    }
}
