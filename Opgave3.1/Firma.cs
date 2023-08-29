using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Firma : IharAdresse
    { 
        public Adresse Adresse { get; set; }
        public String Navn { get; set; }
        public Firma(String navn, Adresse adresse)
        {
            this.Navn = navn;
            this.Adresse = adresse;
        }

        public override string ToString()
        {
            return "Firmanavn: " + this.Navn + ", Adresse: " + this.Adresse;
        }
    }
}
