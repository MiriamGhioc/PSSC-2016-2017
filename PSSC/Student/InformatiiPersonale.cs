using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class InformatiiPersonale
    {
        public int id;
        public NumarMatricol numarMatricol { get; internal set; }
        public PlainText nume { get; internal set; }
        
        //public Note NoteActivitate { get; internal set; }
        //public Nota NotaExamen { get; internal set; }
        //public Nota NotaFinala { get; internal set; }
        
        internal InformatiiPersonale(int _id, NumarMatricol _nrMatricol, PlainText _nume)
        {
            id = _id;
            numarMatricol = _nrMatricol;
            nume = _nume;
          
        }

    }
}
