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
using DinoDiner.Menu;

namespace PointOfSale.ComboDrinkSideScreen
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

        }

        /// <summary>
        /// Changes screen to update for drink as soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    Sodasaurus f = new Sodasaurus();
                    f.Size = Combo.Size;
                    Combo.Drink = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }


        }
        /// <summary>
        /// Changes screen to update for drink as tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tea_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    Tyrannotea f = new Tyrannotea();
                    f.Size = Combo.Size;
                    Combo.Drink = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }

        }
        /// <summary>
        /// Changes screen to update as Java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Java_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    JurassicJava f = new JurassicJava();
                    f.Size = Combo.Size;
                    Combo.Drink = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        /// <summary>
        /// Changes screen to update as water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    Water f = new Water();
                    f.Size = Combo.Size;
                    Combo.Drink = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }

        }
        /// <summary>
        /// Controls lemon button to change it as needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lemon_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) {

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo )
                {
                    if(Combo.Drink is DinoDiner.Menu.Water drink)
                    {
                        if (drink.Lemon)
                        {
                            drink.HoldLemon();

                        }
                        else
                        {
                            drink.AddLemon();
                        }
                    }
                    else if (Combo.Drink is DinoDiner.Menu.Tyrannotea drink2)
                    {
                        if (drink2.Lemon)
                        {
                            drink2.HoldLemon();

                        }
                        else
                        {
                            drink2.AddLemon();
                        }
                    }

                } 

                CollectionViewSource.GetDefaultView(order.Items).Refresh();

            }


        }
        /// <summary>
        /// controls ice button to control it as needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ice_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                    
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink.Ice)
                    {
                        Combo.Drink.HoldIce();
                    }
                    else
                    {
                        Combo.Drink.AddIce();
                    }
                }

                CollectionViewSource.GetDefaultView(order.Items).Refresh();

            }
        }
        /// <summary>
        /// Acts as changing button depending on if the object is soda, java, or tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangingButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    if (Combo.Drink is DinoDiner.Menu.JurassicJava java)
                    {
                        JurassicJava j = new JurassicJava();
                        if (java.Decaf)
                        {
                            j.MakeUndecaf();
                            j.Size = Combo.Size;
                            Combo.Drink = j;
                        }
                        else
                        {
                            j.MakeDecaf();
                            j.Size = Combo.Size;
                            Combo.Drink = j;
                        }
                    }
                    else if (Combo.Drink is DinoDiner.Menu.Sodasaurus soda)
                    {
                        this.NavigationService.Navigate(new ComboDrinkSideScreen.FlavorSelection());

                    }
                    else if (Combo.Drink is DinoDiner.Menu.Tyrannotea tea)
                    {
                        Tyrannotea t = new Tyrannotea();
                        if (tea.Sweet)
                        {
                            t.MakeUnSweet();
                            t.Size = Combo.Size;
                            Combo.Drink = t;

                        }
                        else
                        {
                            t.MakeSweet();
                            t.Size = Combo.Size;
                            Combo.Drink = t;
                        }
                    }



                }
  
                CollectionViewSource.GetDefaultView(order.Items).Refresh();

            }
        }

        /// <summary>
        /// Click event for done to return to main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReturnToMain(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Sets size to size selected. Helper function
        /// </summary>
        /// <param name="size"></param>
        private void SetSize(DinoDiner.Menu.Size size)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink side)
                {
                    side.Size = size;
                    //OrderBox.Items
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                    order.OnCollectionChanged(null, null);


                }
            }
        }

        /// <summary>
        /// Sets size to large of selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeLarge(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Drink side)
                {
                    SetSize(DinoDiner.Menu.Size.Large);
                }
            }
        }

        /// <summary>
        /// sets size to medium for selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeMedium(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Drink side)
                {
                    SetSize(DinoDiner.Menu.Size.Medium);
                }
            }
        }

        /// <summary>
        /// sets size to small for selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeSmall(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Drink side)
                {
                    SetSize(DinoDiner.Menu.Size.Small);
                }
            }
        }
    }
}
