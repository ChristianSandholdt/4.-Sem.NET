using OpgaveLektion17.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveLektion17.Mapper
{
    internal class StuderendeMapper
    {
        internal static DTO.Studerende Map(Studerende studerende)
        {
            DTO.Studerende retur = new DTO.Studerende();
            retur.Id = studerende.Id;
            retur.Navn = studerende.Navn;
            return retur;
        }
    }
}
