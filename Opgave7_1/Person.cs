using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave7_1
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public String Name { get; set; }
        private int age;
        public int Age {
            set
            {
                age = value;
                notifyPropertyChanged("Age");
            }
            get
            {
                return age;
            }

        }
        public int Weight { get; set; }

        public int Score { get; set; }
        public bool Accepted { get; set; }

        private void notifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
