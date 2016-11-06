using Disciplina;
using Nota;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class InformatiiFacultate
    {
        public InformatiiDisciplina materie { get; internal set; }
        public InformatiiNota note { get; internal set; }
        public int anStudiu;

        internal InformatiiFacultate(InformatiiDisciplina _materie, InformatiiNota _note, int _anStudiu)
        {
            materie = _materie;
            note = _note;
            anStudiu = _anStudiu;
        }
    }
}
