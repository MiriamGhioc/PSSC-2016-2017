using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
   public class NumarMatricol
    {
        private string _numar;
        public string Numar { get { return _numar; } }

        public NumarMatricol(string numar)
        {
           
            _numar = numar;
        }
    }
}
