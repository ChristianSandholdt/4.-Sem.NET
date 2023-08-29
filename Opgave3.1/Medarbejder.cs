using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal abstract class Medarbejder
    {
        public CprNr Cpr { get; set; }
        public String Navn { get; set; }

        public String Adresse { get; set; }

        public Medarbejder(CprNr cpr,String navn, String adresse) {
            this.Cpr = cpr;
            this.Navn = navn;
            this.Adresse = adresse;
        }
        public abstract String beregnUgeLoen();
       

        public override string ToString()
        {
            return "Navn: " + this.Navn + ", Adresse: " + this.Adresse
                 + ", Cpr: " + this.Cpr.ToString() + ", Ugeløn: " + beregnUgeLoen();
        }
    }
}
