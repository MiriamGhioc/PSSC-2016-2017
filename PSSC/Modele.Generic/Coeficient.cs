using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class Coeficient
    {
        private int numarator;
        private int numitor;

        public decimal Fractie { get { return (decimal)numarator / (decimal)numitor; } }

        internal Coeficient(int numa, int numi)
        {
            numitor = numi;
            numarator = numa;
        }
    }
}
