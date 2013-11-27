using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class MemberSchemaManager : IMemberSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(MemberSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MemberSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MemberSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public MemberSchemaModel SingleOrDefault(Expression<Func<MemberSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MemberSchemaModel SingleOrDefault(Expression<Func<MemberSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MemberSchemaModel> Find(Expression<Func<MemberSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MemberSchemaModel> Find(Expression<Func<MemberSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
