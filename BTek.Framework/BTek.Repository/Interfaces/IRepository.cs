using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace BTek.Repository.Interfaces
{
    public interface IRepository<E> : IDisposable where E : class
    {
        void Save();
        void Create(E entity);
        void Update(E entity);
        void Delete(E entity);
        E SingleOrDefault(Expression<Func<E, bool>> predicate, List<string> includes);
        E SingleOrDefault(Expression<Func<E, bool>> predicate);
        IQueryable<E> Find(Expression<Func<E, bool>> predicate, List<string> includes);
        IQueryable<E> Find(Expression<Func<E, bool>> predicate);
        IQueryable<E> GetAll(List<string> includes);
        IQueryable<E> GetAll();

    }
}
