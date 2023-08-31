using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Adresse
    {
        public String VejNavn { get; set; }
        public int HusNummer { get; set; }

        public Adresse(String vejNavn, int husNummer) {
            this.VejNavn = vejNavn;
            this.HusNummer = husNummer;
        }

        public override String ToString() {
            return VejNavn + " " + HusNummer;
        }
    }
}
