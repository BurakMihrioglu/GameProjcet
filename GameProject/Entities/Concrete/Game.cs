using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities.Concrete
{
    class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string UnitPrice { get; set; }
    }
}
