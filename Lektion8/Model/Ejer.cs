using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lektion8;

namespace Opgave8_1.Model
{
    [Table("ejere")]
    public class Ejer
    {
        public int EjerID { get; set; }
        public string Name { get; set; }
        public virtual List<Bil> biler { get; } = new List<Bil>();
        public Ejer(string name): this()
        {
            Name = name;
        }
        public Ejer()
        {
            biler = new List<Bil>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
