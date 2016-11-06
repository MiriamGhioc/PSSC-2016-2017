using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disciplina
{
    public class Laborator
    {
        public PlainText nume { get; internal set; }

        internal Laborator(PlainText _nume)
        {
            
            nume = _nume;
        }

    }
}
