using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Opgave_6_9
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

        private void leftAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (leftTextbox.Text.Length > 0)
            {
                String s = leftTextbox.Text;
                leftListBox.Items.Add(s);
                leftTextbox.Clear();
            }
        }

        private void rightAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (rightTextBox.Text.Length > 0)
            {
                String s = rightTextBox.Text;
                rightListBox.Items.Add(s);
                rightTextBox.Clear();
            }
        }

        private void leftToRightArrow_Click(object sender, RoutedEventArgs e)
        {
            List<int> indexes = new List<int>();
            foreach (String s in leftListBox.SelectedItems)
            {
                rightListBox.Items.Add(s);
            }
            foreach (String s in leftListBox.SelectedItems)
            {
                indexes.Add(leftListBox.Items.IndexOf(s));
            }
            for (int i = indexes.Count -1; i >= 0; i--)
            {
                leftListBox.Items.RemoveAt(indexes[i]);
            }
        }

        private void rightToLeftArrow_Click(object sender, RoutedEventArgs e)
        {
            List<int> indexes = new List<int>();
            foreach (String s in rightListBox.SelectedItems)
            {
                leftListBox.Items.Add(s);
            }
            foreach (String s in rightListBox.SelectedItems)
            {
                indexes.Add(rightListBox.Items.IndexOf(s));
            }
            for (int i = indexes.Count -1; i >= 0; i--)
            {
                rightListBox.Items.RemoveAt(indexes[i]);
            }

        }

        private void leftClear_Click(object sender, RoutedEventArgs e)
        {
            leftListBox.Items.Clear();
        }

        private void rightClear_Click(object sender, RoutedEventArgs e)
        {
            rightListBox.Items.Clear();
        }


    }
}
    

