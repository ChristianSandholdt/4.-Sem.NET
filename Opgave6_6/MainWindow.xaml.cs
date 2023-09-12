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

namespace Opgave6_6
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

        private void nordKnap_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text += nordKnap.Content.ToString() + "\n";
        }

        private void østKnap_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text += østKnap.Content.ToString() + "\n";
        }

        private void vestKnap_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text += vestKnap.Content.ToString() + "\n";
        }

        private void sydKnap_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text += sydKnap.Content.ToString() + "\n";
        }
    }
}
