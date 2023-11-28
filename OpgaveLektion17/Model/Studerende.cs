using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveLektion17.Model
{
    internal class Studerende
    {
        public String Navn { get; set; }
        public int Id { get; set; }

        public Studerende(int id, String navn)
        {
            this.Navn = navn;
            this.Id = id;
        }

    }
}
