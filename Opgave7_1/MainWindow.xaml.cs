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

namespace Opgave7_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p = new Person();
        public MainWindow()
        {
            InitializeComponent();
            p.Name = "Martin";
            p.Weight = 80;
            p.Age = 25;
            p.Accepted = true;
            p.Score = 10;

            tbNavn.DataContext = p;
            tbAlder.DataContext = p;
            tbVægt.DataContext = p;
            tbScore.DataContext = p;
            cbAccepted.DataContext = p;

            }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            p.Age = 69;

        }

        private void btnPrintPerson_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(p.Name + " " + p.Age + " " + p.Weight + " " + p.Score + " " + p.Accepted);
            Console.WriteLine(p.Name + " " + p.Age + " " + p.Weight + " " + p.Score + " " + p.Accepted);
        }
    }
}
