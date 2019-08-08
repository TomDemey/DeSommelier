using Sommelier.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sommelier.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
