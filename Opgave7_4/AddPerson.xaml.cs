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
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Window
    {
        ListBox listbox;
        Person person;
        public AddPerson(ListBox l)
        {
            listbox = l;
            InitializeComponent();
            listbox.DataContext = person;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person(tbNavn.Text, Int32.Parse(tbAlder.Text), Int32.Parse(tbVægt.Text), Int32.Parse(tbScore.Text), (bool)cbAccepted.IsChecked);
            listbox.Items.Add(p);


        }

    }
}
