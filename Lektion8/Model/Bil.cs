using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave8_1.Model
{
    [Table("biler")]
    public class Bil : INotifyPropertyChanged
    {
{
        public event PropertyChangedEventHandler? PropertyChanged;


        public int BilID { get; set; }
        public string Color
        {
            set
            {
                Color = value;
                notifyPropertyChanged("Color");
            }
            get { return Color; }
        }
        public string Plate
        {
            set
            {
                Plate = value;
                notifyPropertyChanged("Plate");
            }
            get { return Plate; }
        }

        public string Manufacturer
        {
            set
            {
                Plate = value;
                notifyPropertyChanged("Plate");
            }
            get { return Plate; }
        }


        public string Manufacturer { get; set; }
        public int Age { get; set; }

        public virtual Ejer? Ejer { get; set; }

        public int EjerID { get; set; }
        private void notifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        internal Bil(string color, string plate, string manufacturer, int ejerID)
        {
            Color = color;
            Plate = plate;
            Manufacturer = manufacturer;
            Age = 15;
            EjerID = ejerID;
        }

        public Bil()
        {
        }

        public Bil(string color, string plate, string manufacturer)
        {
            Color = color;
            Plate = plate;
            Manufacturer = manufacturer;
            Age = 15;
        }

        public override string ToString()
        {
            return "BilId = " + BilID + " Color = " + Color + " Plate = " + Plate + " Manufacturer = " + Manufacturer + "Age = " + Age;
        }
    }
}
