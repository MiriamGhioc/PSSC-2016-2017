using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy
{
    public class DisciplinaRepository:IRepository<Student.InformatiiPersonale>
    {
        public IEnumerable<Student.InformatiiPersonale> List
        {
            get { throw new NotImplementedException(); }
        }

        public void Add(Student.InformatiiPersonale entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student.InformatiiPersonale entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Student.InformatiiPersonale entity)
        {
            throw new NotImplementedException();
        }

        public Student.InformatiiPersonale FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
