using System;
using GameDemo.Entities;
using GameDemo.Concrete;
using GameDemo.Abstract;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { FirstName = "Batuhan", LastName = "Arslan", NationalityId = "12345678910", DateOfBirth = new DateTime(2000, 1, 14) };

            IGamerCheckService gamerCheckService = new GamerCheckManager();
            GamerManager gamerManager = new GamerManager(gamerCheckService);
            gamerManager.Save(gamer);
            gamerManager.Update(new Gamer { FirstName = "Ahmet" });
            gamerManager.Delete(new Gamer());

            Campaign campaign = new Campaign { Name = "Efsane Cuma" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign);
            campaignManager.UpdateCampaign(new Campaign { Name = "Yaz İndirmleri" });
            campaignManager.RemoveCampaign(new Campaign());

            Game game = new Game { Name = "SpellForce 3", Type = "Real Time Strategy, Role Play Game", Price = 26 };
            ICampaignCheckService campaignCheckService = new CampaignCheckManager();
            GameManager gameManager = new GameManager(campaignCheckService);
            gameManager.AddGame(game);
            gameManager.Sale(game, gamer, campaign);

        }
    }
}
