using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IOrderService : IProductService, IUserService, ICampaignService
    {
        void Create(Order order, Product product, User user, Campaign campaign);
        void Remove(Order order, Product product, User user, Campaign campaign);
        void Uptade(Order order, Product product, User user, Campaign campaign);
    }
}
