using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class StageSchemaManager : IStageSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(StageSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(StageSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(StageSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public StageSchemaModel SingleOrDefault(Expression<Func<StageSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public StageSchemaModel SingleOrDefault(Expression<Func<StageSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StageSchemaModel> Find(Expression<Func<StageSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StageSchemaModel> Find(Expression<Func<StageSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
