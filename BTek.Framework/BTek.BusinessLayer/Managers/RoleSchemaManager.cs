using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class RoleSchemaManager : IRoleSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(RoleSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(RoleSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(RoleSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public RoleSchemaModel SingleOrDefault(Expression<Func<RoleSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public RoleSchemaModel SingleOrDefault(Expression<Func<RoleSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleSchemaModel> Find(Expression<Func<RoleSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleSchemaModel> Find(Expression<Func<RoleSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
