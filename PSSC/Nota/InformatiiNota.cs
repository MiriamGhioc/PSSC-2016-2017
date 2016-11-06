using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    public class InformatiiNota
    {
        public int id;
       
        public NotaT notaActivitate {get; internal set;}
        public NotaT notaExamen {get; internal set;}
        public NotaT notaMarire {get; internal set;}

        internal InformatiiNota(NotaT notaAct, NotaT notaEx, NotaT notaMar)
        {
            notaActivitate = notaAct;
            notaExamen = notaEx;
            notaMarire = notaMar;
        }
    }
}
