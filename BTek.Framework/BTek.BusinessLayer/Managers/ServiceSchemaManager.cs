using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class ServiceSchemaManager : IServiceSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(ServiceSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ServiceSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ServiceSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public ServiceSchemaModel SingleOrDefault(Expression<Func<ServiceSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ServiceSchemaModel SingleOrDefault(Expression<Func<ServiceSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServiceSchemaModel> Find(Expression<Func<ServiceSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ServiceSchemaModel> Find(Expression<Func<ServiceSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
