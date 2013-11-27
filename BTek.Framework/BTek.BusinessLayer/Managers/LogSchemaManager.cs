using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class LogSchemaManager : ILogSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(LogSchema entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LogSchema entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LogSchema entity)
        {
            throw new NotImplementedException();
        }

        public LogSchema SingleOrDefault(Expression<Func<LogSchema, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LogSchema SingleOrDefault(Expression<Func<LogSchema, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogSchema> Find(Expression<Func<LogSchema, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogSchema> Find(Expression<Func<LogSchema, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
