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
using System.Windows.Shapes;

namespace Opgave7_4
{
    /// <summary>
    /// Interaction logic for EditPerson.xaml
    /// </summary>
    public partial class EditPerson : Window
    {
        Person person;
        public EditPerson(Person p)
        {
            InitializeComponent();
            Person person = p;
            tbNavn.Text = person.Name;
            tbAlder.Text = person.Age.ToString();
            tbVægt.Text = person.Weight.ToString();
            tbScore.Text = person.Score.ToString();
            cbAccepted.IsChecked = person.Accepted; 

            editGrid.DataContext = person;
        }
        

        //Save knappen. Opdaterer properties på objektet så det også ændres i selve koden
        //og ikke kun i GUI. Lukker til sidst vinduet.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.Name = tbNavn.Text;
            person.Age = Int32.Parse(tbAlder.Text);
            person.Weight = Int32.Parse(tbVægt.Text);
            person.Score = Int32.Parse(tbScore.Text);
            person.Accepted = (bool)cbAccepted.IsChecked;
            Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            person.Accepted = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            person.Accepted = false;
        }
    }
}
