using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi: " + campaign.Name);
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi: " + campaign.Name);
        }

        public void RemoveCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi: " + campaign.Name);
        }
    }
}
