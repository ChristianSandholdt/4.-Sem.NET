using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Opgave7_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Person> personer = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();
            personer.Add(new Person("Martin", 25, 100, 10, true));
            personer.Add(new Person("Gert", 43, 80, 11, true));
            personer.Add(new Person("Hans", 20, 105, 20, true));
            personer.Add(new Person("Ib", 27, 60, 40, false));
            personer.Add(new Person("John", 2, 15, 67, false));
            personer.Add(new Person("Pablo", 23, 56, 15, true));
            personer.Add(new Person("Noel", 16, 78, 110, false));
            personer.Add(new Person("Yaya", 95, 43, 19, false));
            personer.Add(new Person("Kolo", 34, 65, 18, true));
            personer.Add(new Person("Jasper", 54, 72, 16, false));
            personer.Add(new Person("Christian", 29, 97, 11, true));
            lbPersons.ItemsSource = personer;
        }
        //Holder øje med om der vælges en anden person i listen og opdaterer felterne
        private void lbPersons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = lbPersons.SelectedItem as Person;
            updateFields(p);
        }
        //Åbner edit vinduet
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var edit = new EditPerson((Person)lbPersons.SelectedItem);
            edit.Closed += Window_Closed;
            edit.ShowDialog();
            
        }
        //Action til når edit vinduet lukkes
        //Listen og felterne opdateres
        private void Window_Closed(object sender, EventArgs e)
        {
            var p = lbPersons.SelectedItem as Person;
            lbPersons.Items.Refresh();
            updateFields(p);
        }
        //Hjælpemetode til ovenstående
        private void updateFields(Person p)
        {
            tbNavn.Text = p.Name;
            tbAlder.Text = p.Age.ToString();
            tbVægt.Text = p.Weight.ToString();
            tbScore.Text = p.Score.ToString();
            cbAccepted.IsChecked = p.Accepted;
        }

        private void cbAccepted_Unchecked(object sender, RoutedEventArgs e)
        {
            var p = lbPersons.SelectedItem as Person;
            p.Accepted = false;
        }

        private void cbAccepted_Checked(object sender, RoutedEventArgs e)
        {
            var p = lbPersons.SelectedItem as Person;
            p.Accepted = true;
        }
    }
}
