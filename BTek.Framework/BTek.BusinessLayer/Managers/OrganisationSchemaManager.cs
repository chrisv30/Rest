using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class OrganisationSchemaManager : IOrganisationSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(OrganisationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(OrganisationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(OrganisationSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public OrganisationSchemaModel SingleOrDefault(Expression<Func<OrganisationSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public OrganisationSchemaModel SingleOrDefault(Expression<Func<OrganisationSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganisationSchemaModel> Find(Expression<Func<OrganisationSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganisationSchemaModel> Find(Expression<Func<OrganisationSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
