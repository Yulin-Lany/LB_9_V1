using LB_9_V1.Domain.Entities;
using LB_9_V1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LB_9_V1.TestData
{
    public class StudentTestRepository : IRepository<Students>
    {
        private readonly List<Students> students;
        public StudentTestRepository(List<Students> students) 
        { 
            this.students = students;
        }
        public void Create(Students entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Students> Find(Expression<Func<Students, bool>> predicate)
        {
            Func<Students, bool> filter = predicate.Compile();
            return students.Where(filter).AsQueryable();
        }

        public Students Get(int id, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Students> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Students entity)
        {
            throw new NotImplementedException();
        }
    }
}
