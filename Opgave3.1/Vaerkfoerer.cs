using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Vaerkfoerer : Mekaniker
    {
        public int UdnaevnelsesAar { get; set; }
        public int  TillaegPrUge { get; set; }

        public Vaerkfoerer(CprNr cprNr, String navn, Adresse adresse, int svendeProeveAar, int timeLoen, int udnaevnelsesAar, int tillaegPrUge) : base(cprNr, navn, adresse, svendeProeveAar,timeLoen) {
            this.UdnaevnelsesAar = udnaevnelsesAar;
            this.TillaegPrUge = tillaegPrUge;
        }

        public override String beregnUgeLoen()
        {
            return this.TimeLoen * 37 + TillaegPrUge + "Kr om ugen";
        }


    }
}
