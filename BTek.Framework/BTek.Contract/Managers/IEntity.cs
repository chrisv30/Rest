using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace BTek.Contract.Managers
{
    public interface IEntity<E>: IDisposable where E: class
    {
        void MapModelsToEntities();

        void Create(E entity);
        void Update(E entity);
        void Delete(E entity);

        E SingleOrDefault(Expression<Func<E, bool>> predicate);
        E SingleOrDefault(Expression<Func<E, bool>> predicate, List<string> includes);

        IEnumerable<E> Find(Expression<Func<E, bool>> predicate);
        IEnumerable<E> Find(Expression<Func<E, bool>> predicate, List<string> includes);
    }
}
