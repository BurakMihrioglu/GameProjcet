using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    interface ISalesService
    {
        void Discount(IEntity entity);
    }
}
