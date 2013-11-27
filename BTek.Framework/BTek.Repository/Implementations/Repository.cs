using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using BTek.Repository.Interfaces;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data;

namespace BTek.Repository.Implementations
{
    public class Repository<E> : IRepository<E> where E : class
    {
        private DbContext db;

        public Repository(DbContext context, bool LazyLoadingEnabled)
        {
            this.db = context;
            this.db.Configuration.LazyLoadingEnabled = LazyLoadingEnabled;
        }

        public void Create(E entity)
        {
            db.Set<E>().Add(entity);
        }

        public void Update(E entity)
        {
            db.Set<E>().Attach(entity);
            db.Entry<E>(entity).State = System.Data.EntityState.Modified;
        }

        public void Delete(E entity)
        {
            db.Set<E>().Remove(entity);
        }

        public E SingleOrDefault(Expression<Func<E, bool>> predicate, List<string> includes)
        {
            var query = (DbQuery<E>)db.Set<E>().AsQueryable();
            if (includes.Count > 0)
                foreach (string child in includes)
                    query = query.Include(child);

            return query.Where(predicate).FirstOrDefault();

        }

        public E SingleOrDefault(Expression<Func<E, bool>> predicate)
        {
            return db.Set<E>().Where(predicate).FirstOrDefault();
        }

        public IQueryable<E> Find(Expression<Func<E, bool>> predicate, List<string> includes)
        {
            var query = (DbQuery<E>)db.Set<E>().AsQueryable();
            if (includes.Count > 0)
                foreach (string child in includes)
                    query = query.Include(child);

            return query.Where(predicate);
        }

        public IQueryable<E> Find(Expression<Func<E, bool>> predicate)
        {
            return db.Set<E>().Where(predicate);
        }

        public IQueryable<E> GetAll(List<string> includes)
        {
            var query = (DbQuery<E>)db.Set<E>().AsQueryable();
            if (includes.Count > 0)
                foreach (string child in includes)
                    query = query.Include(child);

            return query.AsQueryable();
        }

        public IQueryable<E> GetAll()
        {
            return db.Set<E>().AsQueryable();
        }

        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        #region Dispose methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        bool _disposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    if (db != null)
                        db.Dispose();

                db = null;
                _disposed = true;
            }
        }

        #endregion
    }
}
