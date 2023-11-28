using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using OpgaveLektion17.Context;
using OpgaveLektion17.Mapper;

namespace OpgaveLektion17.Repositories
{
    public class StuderendeRepository
    {
        public static Studerende findStuderende(int id)
        {
            using (StuderendeContext context = new StuderendeContext())
            {
                return StuderendeMapper.Map(context.Studerende.Find(id));
            }
        }
    }
}
