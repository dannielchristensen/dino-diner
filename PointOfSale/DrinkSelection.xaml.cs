/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        
        /// <summary>
        /// Creates Drink screen, with the changing button hidden until button is selected
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            uxChangingButton.Visibility = Visibility.Hidden;


        }
        bool lemon = false;
        bool ice = true;
        bool flavor = false;
        bool java = false;
        bool tea = false;
        bool isDecaf = false;
        bool isSweet = false;
        /// <summary>
        /// Changes screen to update for drink as soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            uxChangingButton.Content = "Flavor";
            uxChangingButton.Visibility = Visibility.Visible;

            tea = false;
            java = false;
            flavor = true;
        }
        /// <summary>
        /// Changes screen to update for drink as tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            uxChangingButton.Content = "Sweet";
            uxChangingButton.Visibility = Visibility.Visible;

            tea = true;
            java = false;
            flavor = false;
        }
        /// <summary>
        /// Changes screen to update as Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Java_Click(object sender, RoutedEventArgs e)
        {
            uxChangingButton.Content = "Decaf";
            uxChangingButton.Visibility = Visibility.Visible;

            tea = false;
            java = true;
            flavor = false;
        }
        /// <summary>
        /// Changes screen to update as water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            uxChangingButton.Content = "";
            uxChangingButton.Visibility = Visibility.Hidden; 

            tea = false;
            java = false;
            flavor = false;
        }
        /// <summary>
        /// Controls lemon button to change it as needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lemon_Click(object sender, RoutedEventArgs e)
        {
            lemon = !lemon;
            if (lemon)
            {
                this.Content = "Hold Lemon";

            }
            else
            {
                this.Content = "Add Lemon";
            }
        }
        /// <summary>
        /// controls ice button to control it as needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ice_Click(object sender, RoutedEventArgs e)
        {
            ice = !ice;
            if (ice)
            {
                this.Content = "Hold Ice";
            }
            else
            {
                this.Content = "Add Ice";
            }
        }
        /// <summary>
        /// Acts as changing button depending on if the object is soda, java, or tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangingButton_Click(object sender, RoutedEventArgs e)
        {
            if (flavor)
            {
                this.NavigationService.Navigate(new Uri("FlavorSelection.xaml", UriKind.Relative));

            }
            else if (java)
            {
                isDecaf = !isDecaf;
            }
            else if (tea)
            {
                isSweet = !isSweet;
            }
        }
    }
}
