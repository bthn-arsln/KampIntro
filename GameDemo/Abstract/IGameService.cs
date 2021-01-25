using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    interface IGameService
    {
        void AddGame(Game game);
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
