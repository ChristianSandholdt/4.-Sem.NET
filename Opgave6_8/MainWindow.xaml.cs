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

namespace Opgave6_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void north_Checked(object sender, RoutedEventArgs e)
        {
            rdbResult.Content = "North Checked";
        }

        private void east_Checked(object sender, RoutedEventArgs e)
        {
            rdbResult.Content = "East Checked";
        }

        private void south_Checked(object sender, RoutedEventArgs e)
        {
            rdbResult.Content = "South Checked";
        }

        private void west_Checked(object sender, RoutedEventArgs e)
        {
            rdbResult.Content = "West Checked";
        }


        //Checked
        private void lemon_Checked(object sender, RoutedEventArgs e)
        {
            updateCheckBoxResult();
        }

        private void orange_Checked(object sender, RoutedEventArgs e)
        {
            updateCheckBoxResult();
        }

        private void banana_Checked(object sender, RoutedEventArgs e)
        {
            updateCheckBoxResult();
        }

        //Unchecked
        private void lemon_Unchecked(object sender, RoutedEventArgs e)
        {
            updateCheckBoxResult();
        }

        private void orange_Unchecked(object sender, RoutedEventArgs e)
        {
            updateCheckBoxResult();
        }

        private void banana_Unchecked(object sender, RoutedEventArgs e)
        {
            updateCheckBoxResult();
        }





        //Update
        private void updateCheckBoxResult()
        {
            List<String> concatString = new List<string>();
            String status = "";
            if (lemon.IsChecked == true)
            {
                concatString.Add("Lemon,");
            } else 
            { 
                concatString.Remove("Lemon");
            }
            if (orange.IsChecked == true)
            {
                concatString.Add(" Orange,");
            } else
            {
                concatString.Remove(" Orange,");
            }
            if (banana.IsChecked == true)
            {
                concatString.Add(" Banana,");
            } else
            {
                concatString.Remove(" Banana,");
            }
            for (int i = 0; i < concatString.Count; i++)
            {
                status += concatString[i];
            }
            if (status.Contains(","))
                status = status.Remove(status.Length - 1);
            cBoxResult.Content = status;
        }


    }
}
