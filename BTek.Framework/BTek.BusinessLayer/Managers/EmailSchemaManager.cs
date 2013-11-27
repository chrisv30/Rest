using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class EmailSchemaManager : IEmailSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(EmailSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EmailSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(EmailSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public EmailSchemaModel SingleOrDefault(Expression<Func<EmailSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public EmailSchemaModel SingleOrDefault(Expression<Func<EmailSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmailSchemaModel> Find(Expression<Func<EmailSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmailSchemaModel> Find(Expression<Func<EmailSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
