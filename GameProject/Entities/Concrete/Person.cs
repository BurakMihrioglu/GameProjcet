using GameProject.Business.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Person : IEntity
    {
        public string NationalityNumber { get;  set; }
        public string Name { get;  set; }
        public string LastName { get;  set; }
        public int YearOfBirth { get;  set; }
    }
}
