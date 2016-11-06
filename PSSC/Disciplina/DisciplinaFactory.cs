using Modele.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disciplina
{
    class DisciplinaFactory
    {
        public static readonly DisciplinaFactory Instance = new DisciplinaFactory();

        private DisciplinaFactory()
        {

        }


        public InformatiiDisciplina CreeazaDisciplina(string nume)
        {
            
           var disciplina = new InformatiiDisciplina(
                                        new PlainText(nume),
                                        new Coeficient(1,2));

            return disciplina;
        }
        
    }
}
