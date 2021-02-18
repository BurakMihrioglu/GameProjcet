using GameProject.DataAccess.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.DataAccess.Concrete.File
{
    class FileLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + "Dosyaya başarıyla eklendi!");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + "Dosyayı başarıyla güncelledi!");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + "Dosya başarıyla kaldırıldı!");
        }
    }
}
