using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess.Abstract
{
    interface ILoggerService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);

    }
}
