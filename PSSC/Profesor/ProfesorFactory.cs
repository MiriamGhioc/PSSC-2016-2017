using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    class ProfesorFactory
    {
         public static readonly ProfesorFactory Instance = new ProfesorFactory();

        private ProfesorFactory()
        {

        }
    }
}
