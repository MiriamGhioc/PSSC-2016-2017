using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentFactory
    {
         public static readonly StudentFactory Instance = new StudentFactory();

        private StudentFactory()
        {

        }
    }
}
