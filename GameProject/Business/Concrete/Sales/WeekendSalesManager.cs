﻿using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete.Sales
{
    class WeekendSalesManager : ISalesService
    {
        public void Discount(IEntity game)
        {
            Console.WriteLine(game.Name + " Oyununa hafta sonu indirimi yapıldı!");
        }
    }
}
