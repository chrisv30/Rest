using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class LogBookSchemaManager : ILogBookSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(LogBookSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LogBookSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LogBookSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public LogBookSchemaModel SingleOrDefault(Expression<Func<LogBookSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LogBookSchemaModel SingleOrDefault(Expression<Func<LogBookSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogBookSchemaModel> Find(Expression<Func<LogBookSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogBookSchemaModel> Find(Expression<Func<LogBookSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
