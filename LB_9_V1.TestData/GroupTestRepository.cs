using LB_9_V1.Domain.Entities;
using LB_9_V1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LB_9_V1.TestData
{
    public class GroupTestRepository : IRepository<Groups>
    {
        /// <summary>
        /// Список групп для тестирования прилождения
        /// </summary>
        private readonly List<Groups> groups;
        public GroupTestRepository(List<Groups> groups)
        {
            this.groups = groups;
            SetupData(); // сгенерировать тестовые данные
        }
        private void SetupData()
        {
            var s = 1;
            Random rnd = new Random();
            for (var i = 1; i <= 5; i++)
            {
                var group = new Groups
                {
                    BasePrice = rnd.Next(1000, 5000),
                    Commence = DateTime.Now + TimeSpan.FromDays(rnd.Next(10, 20)),
                    CourseName = $"Группа {i}",
                    GroupId = i
                };
                var students = new List<Students>();
                for (var j = 0; j < 10; j++)
                {
                    students.Add(new Students
                    {
                        GroupId = i,
                        DateOfBirth = DateTime.Now - TimeSpan.FromDays(rnd.Next(6000, 20000)),
                        FullName = $"Студент {s}",
                        StudentId = s,
                        IndividualPrice = (decimal)((double)group.BasePrice * rnd.NextDouble())
                    });
                    s++;
                }
                group.Students = students;
                groups.Add(group);
            }
        }
        public void Create(Groups entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Groups> Find(Expression<Func<Groups, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Groups Get(int id, params string[] includes)
        {
            return groups.FirstOrDefault(g => g.GroupId == id);
        }

        public IQueryable<Groups> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Groups entity)
        {
            throw new NotImplementedException();
        }
    }

}

