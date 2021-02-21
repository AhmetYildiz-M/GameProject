using System;

namespace GameProject.Entities
{
    public class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
    }
}