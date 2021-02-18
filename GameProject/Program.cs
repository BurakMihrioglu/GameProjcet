using GameProject.Business.Abstract;
using GameProject.Business.Concrete;
using GameProject.Business.Concrete.Platforms;
using GameProject.Business.Concrete.Sales;
using GameProject.Business.ValidationRules.Abstract;
using GameProject.Business.ValidationRules.Concrete.Mernis;
using GameProject.DataAccess.Abstract;
using GameProject.DataAccess.Concrete.Database;
using GameProject.DataAccess.Concrete.File;
using GameProject.Entities;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService databaseLogger = new DatabaseLoggerService();
            IValidateService mernisValidateService = new MernisValidateService();

            IEntityService playerManager = new PlayerManager(new List<ILoggerService> { databaseLogger, fileLogger }, new List<IValidateService> { mernisValidateService });

            Person ismail = new Player() { NationalityNumber = "11111111111", Name = "ismail", LastName = "ismail", YearOfBirth = 1985};
            Person mehmet = new Player() { NationalityNumber = "22222222222", Name = "mehmet", LastName = "mehmet", YearOfBirth = 2000};
            Person dilek = new Player() { NationalityNumber = "33333333333", Name = "dilek", LastName = "dilek", YearOfBirth = 2003};
            Person gülden = new Player() { NationalityNumber = "44444444444", Name = "gülden", LastName = "gülden", YearOfBirth = 2000};

            playerManager.Add(ismail);
            playerManager.Add(mehmet);
            playerManager.Add(dilek);
            playerManager.Add(gülden);

            IEntity pubg = new Game() { Id = 1, Name = "PlayerUnknown's Battlegrounds", Publisher = "Bluehole", ReleaseDate = "March 23, 2017", UnitPrice ="85 TL" };
            IEntity minecraft = new Game() { Id = 2, Name = "Minecraft", Publisher = "Markus Alexej Notch Persson; Jens Jeb Bergensten", ReleaseDate = "October 7, 2011", UnitPrice = "100 TL" };
            IEntity rainbowsixsiege = new Game() { Id = 3, Name = "Tom Clancy's Rainbow Six: Siege", Publisher = "Ubisoft Montreal", ReleaseDate = "April 7, 2015", UnitPrice = "90 TL" };
            IEntity rust = new Game() { Id = 4, Name = "Rust", Publisher = "Facepunch Studios", ReleaseDate = "December 11, 2013", UnitPrice = "61 TL" };

            IEntityService gameManager = new GameManager(new List<ILoggerService> { databaseLogger });
            gameManager.Add(pubg);
            gameManager.Add(minecraft);
            gameManager.Add(rainbowsixsiege);
            gameManager.Add(rust);

            ISalesService yaz_indirimi = new SummerSalesManager();
            ISalesService karaCuma_indirimi = new BlackFridaySalesManager();
            ISalesService yilbasi_indirimi = new NewYearSalesManager();
            ISalesService haftasonu_inidirimi = new WeekendSalesManager();

            IPlatformService steam = new SteamPlatformManager(new List<ISalesService> {});
            IPlatformService epic_games = new EpicGamesPlatformManager(new List<ISalesService> { karaCuma_indirimi, haftasonu_inidirimi });

            steam.BuyGame(ismail, pubg);
            epic_games.BuyGame(mehmet, rust);
            steam.BuyGame(dilek, rainbowsixsiege);
            epic_games.BuyGame(gülden, minecraft);
        }
    }
}
