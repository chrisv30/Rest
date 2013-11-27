using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class LocationSchemaManager : ILocationSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(LocationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LocationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LocationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public LocationSchemaModel SingleOrDefault(Expression<Func<LocationSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LocationSchemaModel SingleOrDefault(Expression<Func<LocationSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LocationSchemaModel> Find(Expression<Func<LocationSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LocationSchemaModel> Find(Expression<Func<LocationSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
