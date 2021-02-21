using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseOrderManager : IOrderService, IUserService, IProductService, ICampaignService
    {
        public virtual void UserValidation(User user)
        {
        }

        public virtual void Add(User user)
        {
        }

        public virtual void Remove(User user)
        {
        }

        public virtual void Uptade(User user)
        {
        }

        public virtual void Add(Product product)
        {
        }

        public virtual void Remove(Product product)
        {
        }

        public virtual void Uptade(Product product)
        {
        }

        public virtual void Add(Campaign campaign)
        {
        }

        public virtual void Remove(Campaign campaign)
        {
        }

        public virtual void Uptade(Campaign campaign)
        {
        }

        public virtual void Create(Order order, Product product, User user, Campaign campaign)
        {
        }

        public virtual void Remove(Order order, Product product, User user, Campaign campaign)
        {
        }

        public virtual void Uptade(Order order, Product product, User user, Campaign campaign)
        {
        }
    }
}
