using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class OrderManager : BaseOrderManager
    {

        internal void Create(Order orderOne)
        {
            Console.WriteLine($"Order is created. " +
                              $"\n1. Order ID : {orderOne.Id}" +
                              $"\n2. Order City : {orderOne.City} " +
                              $"\n3. Order Country : {orderOne.Country}" +
                              $"\n4. Order Price : {orderOne.OrderPrice}" +
                              $"\n5. Order Date : {orderOne.OrderDate}" +
                              $"\n6. Order Name : ");
        }
    }
}
