using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class CampaignCheckManager : ICampaignCheckService
    {
        public bool CheckCampaign(Campaign campaign)
        {
            return true;
        }
    }
}
