using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4._2
{
    internal class PowerPlant
    {
        private Warning WarningSignal;
        Random random = new Random();
        public delegate void Warning(int x);
       

        public void setWarning(Warning warning)
        {
            WarningSignal = warning;
        }

        public void addWarning(Warning warning)
        {
            WarningSignal += warning;
        }

        public void heatUp()
        {
            int x = random.Next(100);
            if (x > 50)
            {
                WarningSignal.Invoke(x);
            } 
        }
    }
}
