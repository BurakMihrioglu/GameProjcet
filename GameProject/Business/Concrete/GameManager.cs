using GameProject.Business.Abstract;
using GameProject.DataAccess.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    class GameManager : IEntityService
    {
        List<ILoggerService> _loggerServices;
        public GameManager(List<ILoggerService> loogerService)
        {
            _loggerServices = loogerService;
        }

        public void Add(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Update(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(game);
            }
        }

        public void Delete(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(game);
            }
        }
    }
}
