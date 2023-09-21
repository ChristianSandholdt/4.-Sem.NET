using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave8_1.Model
{
    [Table("huse")]
    public class Hus
    {
        public int HusID { get; set; }
        public string Adresse { get; set; }
        public int EjerID { get; set; }
        public virtual List<Ejer> Ejere { get; } = new List<Ejer>();

        public Hus()
        {
            Ejere = new List<Ejer>();
        }
        public Hus(string adresse, int ejerID)
        {
            Adresse = adresse;
            EjerID = ejerID;
        }

        public override string ToString()
        {
            return Adresse;
        }
    }
}
