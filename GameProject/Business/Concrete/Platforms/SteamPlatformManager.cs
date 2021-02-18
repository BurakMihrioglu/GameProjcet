using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete.Platforms
{
    class SteamPlatformManager : IPlatformService
    {
        List<ISalesService> _salesService;
        public SteamPlatformManager(List<ISalesService> salesServices)
        {
            _salesService = salesServices;
        }
        public void BuyGame(IEntity person, IEntity game)
        {
            foreach (var sale in _salesService)
            {
                sale.Discount(game);
            }
            Console.WriteLine(person.Name + " " + game.Name + " Oyunu Steam Platformundan satın aldı! ");
        }

        public void ToRefund(IEntity person, IEntity game)
        {
            Console.WriteLine(person.Name + " " + game.Name + " Oyunu Steam Platformuna iade etti!");
        }

        
    }
}
