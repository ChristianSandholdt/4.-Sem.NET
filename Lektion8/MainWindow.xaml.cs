using Lektion8.Context;
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

namespace Lektion8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BilContext context = new BilContext();
        public MainWindow()
        {
            InitializeComponent();
            bool created = context.Database.EnsureCreated();
            if (created)
            {
                MessageBox.Show("Database created");
            }
            foreach(Bil bil in context.Biler)
            {
                lbCarView.Items.Add(bil);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bil b = new Bil("Red", "FZ95378", "VW");
            context.SaveChanges();
            lbCarView.Items.Add(b);
        }
    }
}
