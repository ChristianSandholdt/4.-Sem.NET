using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3._1
{
    internal class CprNr
    {
        public String Birthdate {  get; set; }
        public String SequenceNumber { get; set; }

        public CprNr(string birthdate, string sequenceNumber)
        {
            Birthdate = birthdate;
            SequenceNumber = sequenceNumber;
        }

        public override String ToString()
        {
            return this.SequenceNumber;
        }
    }
}
