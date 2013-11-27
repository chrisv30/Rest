using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.Contract.Managers;
using BTek.BusinessObjects.Entities;
using System.Linq.Expressions;

namespace BTek.BusinessLayer.Managers
{
    public class TaskSchemaManager : ITaskSchemaManager
    {
        public void MapModelsToEntities()
        {
            throw new NotImplementedException();
        }

        public void Create(TaskSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TaskSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TaskSchemaModel entity)
        {
            throw new NotImplementedException();
        }

        public TaskSchemaModel SingleOrDefault(Expression<Func<TaskSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TaskSchemaModel SingleOrDefault(Expression<Func<TaskSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskSchemaModel> Find(Expression<Func<TaskSchemaModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskSchemaModel> Find(Expression<Func<TaskSchemaModel, bool>> predicate, List<string> includes)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
