using Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class InformatiiFacultate
    {
        public InformatiiDisciplina materie { get; internal set; }

        internal InformatiiFacultate(InformatiiDisciplina _materie)
        {
            materie = _materie;
        }
    }
}
