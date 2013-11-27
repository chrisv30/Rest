using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;
using AutoMapper;
using BTek.Data;

namespace BTek.BusinessLayer.Managers
{
    public class UserSchemaManager: IUserSchemaManager
    {
        public void MapModelsToEntities()
        {
            Mapper.CreateMap<UserSchema, UserSchemaModel>();
        }

        public void Create(UserSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(UserSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public UserSchemaModel SingleOrDefault(Expression<Func<UserSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public UserSchemaModel SingleOrDefault(Expression<Func<UserSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserSchemaModel> Find(Expression<Func<UserSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserSchemaModel> Find(Expression<Func<UserSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
