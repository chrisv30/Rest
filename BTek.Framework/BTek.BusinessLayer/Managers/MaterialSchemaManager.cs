using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class MaterialSchemaManager : IMaterialSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(MaterialSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MaterialSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MaterialSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public MaterialSchemaModel SingleOrDefault(Expression<Func<MaterialSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MaterialSchemaModel SingleOrDefault(Expression<Func<MaterialSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaterialSchemaModel> Find(Expression<Func<MaterialSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MaterialSchemaModel> Find(Expression<Func<MaterialSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
