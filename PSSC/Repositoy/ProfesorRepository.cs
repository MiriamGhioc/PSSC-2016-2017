using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy
{
    public class ProfesorRepository:IRepository<Profesor.InformatiiPersonale>
    {
        public IEnumerable<Profesor.InformatiiPersonale> List
        {
            get { throw new NotImplementedException(); }
        }

        public void Add(Profesor.InformatiiPersonale entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Profesor.InformatiiPersonale entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Profesor.InformatiiPersonale entity)
        {
            throw new NotImplementedException();
        }

        public Profesor.InformatiiPersonale FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
