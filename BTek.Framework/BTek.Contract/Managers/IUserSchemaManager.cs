﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BTek.BusinessObjects.Entities;

namespace BTek.Contract.Managers
{
    public interface IUserSchemaManager: IEntity<UserSchemaModel>, IDisposable
    {
        void MapModelsToEntities();
    }
}
