using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy
{
   public  class NotaRepository:IRepository<Nota.InformatiiNota>
    {
        public IEnumerable<Nota.InformatiiNota> List
        {
            get { throw new NotImplementedException(); }
        }

        public void Add(Nota.InformatiiNota entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Nota.InformatiiNota entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Nota.InformatiiNota entity)
        {
            throw new NotImplementedException();
        }

        public Nota.InformatiiNota FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
