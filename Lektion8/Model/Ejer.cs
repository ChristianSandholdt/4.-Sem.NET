using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave8_1.Model
{
    [Table("ejere")]
    public class Ejer
    {
        public int EjerID { get; set; }
        public string Name { get; set; }
        public virtual List<Bil> biler { get; } = new List<Bil>();

        public virtual List<Hus> Huse { get; } = new List<Hus>();
        public Ejer(string name): this()
        {
            Name = name;
        }
        public Ejer()
        {
            biler = new List<Bil>();
            Huse = new List<Hus>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
