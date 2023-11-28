using OpgaveLektion17.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BLL
{
    public class StuderendeBLL
    {
        public DTO.Studerende findStuderende(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("id");
            }
            return StuderendeRepository.findStuderende(id);
        }
    }
}
