using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        private ICampaignCheckService _campaignCheckService;

        public GameManager(ICampaignCheckService campaignCheckService)
        {
            _campaignCheckService = campaignCheckService;
        }

        public void AddGame(Game game)
        {
            Console.WriteLine("Oyun Eklendi: " + game.Name + " " + game.Price + "TL fiyat belirlendi");
        }
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            if (_campaignCheckService.CheckCampaign(campaign))
            {
                Console.WriteLine(game.Name + " adlı oyun " + gamer.FirstName + " adlı oyuncuya uygulanan " + campaign.Name + " kampanyası ile " + (game.Price - 15) + "TL fiyata satıldı");
            }
            else
            {
                Console.WriteLine(game.Name + " adlı oyun " + gamer.FirstName + " adlı oyuncuya orjinal fiyatı " + game.Price + "TL fiyata satıldı");
            }
        }
    }
}
