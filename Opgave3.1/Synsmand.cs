using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Synsmand : Mekaniker
    {
        public int AntalUgentligeSyn { get; set; }
        public int UgeLoen { get; }

        public Synsmand(CprNr cprNr, String navn, String adresse, int svendeProeveAar, int timeLoen,int antalUgentligeSyn) :base(cprNr,navn, adresse, svendeProeveAar, timeLoen) {
            this.AntalUgentligeSyn = antalUgentligeSyn;
            this.UgeLoen = 290 * AntalUgentligeSyn;
        }

        public override String beregnUgeLoen()
        {
            return 37 * TimeLoen + UgeLoen+ "Kr om ugen";
        }
    }
}
