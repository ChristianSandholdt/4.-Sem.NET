using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class Mekaniker : Medarbejder
    {
        public int SvendeProeveAar { get; set; }
        public int TimeLoen { get; set; }

        public Mekaniker(CprNr cprnr,String navn, Adresse adresse, int svendeProeveAar, int timeLoen) : base(cprnr, navn, adresse) {
            this.SvendeProeveAar = svendeProeveAar;
            this.TimeLoen = timeLoen;
        }

        public override String beregnUgeLoen()
        {
            return TimeLoen * 37 + "Kr om ugen";
        }
    }
}
