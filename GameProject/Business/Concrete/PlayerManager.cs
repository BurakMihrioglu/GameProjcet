using GameProject.Business.Abstract;
using GameProject.Business.ValidationRules.Abstract;
using GameProject.DataAccess.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    class PlayerManager : IEntityService
    {
        List<ILoggerService> _loggerServices;
        List<IValidateService> _validateServices;

        public PlayerManager(List<ILoggerService> loggerServices, List<IValidateService> validateServices)
        {
            _loggerServices = loggerServices;
            _validateServices = validateServices;
        }

        

        public void Add(IEntity person)
        {
            try
            {
                foreach (var validator in _validateServices)
                {
                    validator.Validate((Person)person);
                }
                foreach (var logger in _loggerServices)
                {
                    logger.Add(person);
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        public void Update(IEntity person)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(person);
            }
        }

        public void Delete(IEntity person)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(person);
            }
        }
    }
}
