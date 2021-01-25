using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine("Oyuncu kaydı başarılı: " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Oyuncu kaydı başarısız");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi. " + "Yeni Adınız: " + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi");
        }
    }
}
