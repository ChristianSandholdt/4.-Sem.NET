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

namespace Opgave6_7
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

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            statusbar.Text = "Status: Open";
        }

        private void Save_as_Click(object sender, RoutedEventArgs e)
        {
            statusbar.Text = "Status: Save as";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            statusbar.Text = "Status: Exit";
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            statusbar.Text = "Status: About";
        }
    }
}
