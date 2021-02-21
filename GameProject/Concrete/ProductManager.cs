using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class ProductManager : BaseProductManager
    {

        public override void Add(Product product)
        {
            Console.WriteLine($"{product.ProductName+ " "} is added to cart.");

        }

        public override void Remove(Product product)
        {
            Console.WriteLine($"{product.ProductName + " "} is removed from the cart.");

        }

        public override void Uptade(Product product)
        {
            Console.WriteLine($"The Leabu Legends is updated as {product.ProductName + "."} ");

        }

    }
}
