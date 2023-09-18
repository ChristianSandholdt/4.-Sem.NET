using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion8
{
    [Table("biler")]
    class Bil
    {
        public int BilID { get; set; }
        public string Color { get; set; }
        public string Plate { get; set; }

        public string Manufacturer { get; set; }

        public int Age { get; set; }

        internal Bil(int bilID, string color, string plate, string manufacturer)
        {
            BilID = bilID;
            Color = color;
            Plate = plate;
            Manufacturer = manufacturer;
            Age = 15;
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
