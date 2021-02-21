using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Remove(Product product);
        void Uptade(Product product);

    }
}
