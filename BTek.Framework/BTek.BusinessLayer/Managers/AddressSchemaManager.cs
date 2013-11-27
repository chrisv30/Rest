using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class AddressSchemaManager : IAddressSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(AddressSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(AddressSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AddressSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public AddressSchemaModel SingleOrDefault(Expression<Func<AddressSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public AddressSchemaModel SingleOrDefault(Expression<Func<AddressSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AddressSchemaModel> Find(Expression<Func<AddressSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AddressSchemaModel> Find(Expression<Func<AddressSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
