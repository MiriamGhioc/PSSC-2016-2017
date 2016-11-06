using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disciplina
{
    public class InformatiiDisciplina
    {
        public int id;
        public PlainText nume { get; internal set; }
        public Coeficient PondereExamen { get; internal set; }

        internal InformatiiDisciplina(PlainText _nume, Coeficient pondereExamen)
        {
            nume = _nume;
            PondereExamen = pondereExamen;
        }

    }
}
