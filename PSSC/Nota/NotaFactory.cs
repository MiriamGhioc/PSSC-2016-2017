using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota
{
    class NotaFactory
    {
         public static readonly NotaFactory Instance = new NotaFactory();

        private NotaFactory()
        {

        }
    }
}
