using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class InvitationSchemaManager : IInvitationSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(InvitationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(InvitationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(InvitationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public InvitationSchemaModel SingleOrDefault(Expression<Func<InvitationSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public InvitationSchemaModel SingleOrDefault(Expression<Func<InvitationSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvitationSchemaModel> Find(Expression<Func<InvitationSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvitationSchemaModel> Find(Expression<Func<InvitationSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
