using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class ProjectSchemaManager : IProjectSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(ProjectSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ProjectSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProjectSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public ProjectSchemaModel SingleOrDefault(Expression<Func<ProjectSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ProjectSchemaModel SingleOrDefault(Expression<Func<ProjectSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectSchemaModel> Find(Expression<Func<ProjectSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectSchemaModel> Find(Expression<Func<ProjectSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
