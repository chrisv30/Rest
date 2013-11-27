using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using System.Linq.Expressions;
using BTek.BusinessObjects.Entities;

namespace BTek.BusinessLayer.Managers
{
    public class UserScheduledSchemaManager : IUserScheduledSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(UserScheduledSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserScheduledSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserScheduledSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public UserScheduledSchemaModel SingleOrDefault(Expression<Func<UserScheduledSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public UserScheduledSchemaModel SingleOrDefault(Expression<Func<UserScheduledSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserScheduledSchemaModel> Find(Expression<Func<UserScheduledSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserScheduledSchemaModel> Find(Expression<Func<UserScheduledSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
