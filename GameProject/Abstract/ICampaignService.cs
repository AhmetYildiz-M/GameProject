using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Remove(Campaign campaign);
        void Uptade(Campaign campaign);

    }
}
