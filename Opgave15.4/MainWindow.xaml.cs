using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
namespace Opgave15._4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            var stringTask = client.GetStringAsync("https://localhost:7096/api/Person/all");
            var msg = stringTask.Result;
            MessageBox.Show(msg);
        }

        private async void tronald_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("https://www.tronalddump.io/random/quote");
            var msg = response.Content.ReadAsStringAsync();
            //MessageBox.Show(msg);
        }
    }
}
