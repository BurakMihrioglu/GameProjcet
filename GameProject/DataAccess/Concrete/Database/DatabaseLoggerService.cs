using GameProject.DataAccess.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess.Concrete.Database
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + "Veritabanına başarıyla eklendi!");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + "Veritabanında başarıyla güncellendi!");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + "Veritabanından başarıyla kaldırıldı!");
        }
    }
}
