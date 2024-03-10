using LB_9_V1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_9_V1.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Students> StudentsRepository { get; }
        IRepository<Groups> GroupsRepository { get; }
        void SaveChanges(); //сохранить изменение в БД
    }
}
