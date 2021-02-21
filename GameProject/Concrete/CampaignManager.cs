using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class CampaignManager : BaseCampaignManager
    {
        public override void Add(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} named campaign has been added to the system.");
        }

        public override void Remove(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName + " "} named campaign has been deleted from the system.");
        }

        public override void Uptade(Campaign campaign)
        {
            Console.WriteLine($"The {campaign.CampaignName} campaign's discount rate is updated from 10 to {campaign.DiscountRate}.");
        }

    }
}
