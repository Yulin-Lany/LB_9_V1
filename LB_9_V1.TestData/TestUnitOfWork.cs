using LB_9_V1.Domain.Entities;
using LB_9_V1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LB_9_V1.TestData
{
    public class TestUnitOfWork : IUnitOfWork
    {
        private IRepository<Students> studentsRepository;
        private IRepository<Groups> groupsRepository;
        private List<Groups> groups;
        private List<Students> students;

        public TestUnitOfWork()
        {
            groups = new List<Groups>();
            students = new List<Students>();
            groupsRepository = new GroupTestRepository(groups);
            foreach (var group in groups)
                students.AddRange(group.Students);
            studentsRepository = new StudentTestRepository(students);
        }

        public IRepository<Students> StudentsRepository => studentsRepository;

        public IRepository<Groups> GroupsRepository => groupsRepository;

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
