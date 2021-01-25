using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    interface ICampaignCheckService
    {
        bool CheckCampaign(Campaign campaign);
    }
}
