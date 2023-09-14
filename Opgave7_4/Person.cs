using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave7_4
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private String _name;
        private int _age;
        private int _weight;
        private int _score;
        private bool _accepted;

        public Person(string name, int age, int weight, int score, bool accepted)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _score = score;
            _accepted = accepted;

        }

        public String Name
        {
            set
            {
                _name = value;
                notifyPropertyChanged("Name");
            }
            get { return _name; }
        }
        public int Age {
            set
            {
                _age = value;
                notifyPropertyChanged("Age");
            }
            get
            {
                return _age;
            }

        }
        public int Weight
        {
            set
            {
                _weight = value;
                notifyPropertyChanged("Weight");
            }
            get
            {
                return _weight;
            }
        }

        public int Score
        {
            set
            {
                _score = value;
                notifyPropertyChanged("Score");
            }
            get
            {
                return _score;
            }
        }
        public bool Accepted
        {
            set
            {
                _accepted = value;
                notifyPropertyChanged("Accepted");
            }
            get
            {
                return _accepted;
            }
        }

        private void notifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public override string ToString()
        {
            return this.Name;
        }

    }
}
