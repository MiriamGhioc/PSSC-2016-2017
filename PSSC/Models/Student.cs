using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum discipline{distribuita, examen};
    class Student
    {
        public string nume_student;
        public string Nume_student
        {
            get
            {
                return nume_student;
            }
            set
            {
                nume_student = value;
            }
        }
        public int an_studiu;
        public int nota;
        public int nota_marire;
    }
}
