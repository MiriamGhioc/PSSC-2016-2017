using Disciplina;
using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class InformatiiPersonale
    {
        public int id;
        public PlainText nume { get; internal set; }
       

        internal InformatiiPersonale(int _id, PlainText _nume)
        {
            id = _id;
            nume = _nume;
           
        }
    }
}
