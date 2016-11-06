using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class NotaT
    {
        private decimal _valoare;
        public decimal Valoare { get { return _valoare; } }

        public NotaT(decimal valoare)
        {
           

            _valoare = valoare;
        }
    }
}
