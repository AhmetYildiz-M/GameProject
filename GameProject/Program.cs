using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.UserValidation(new User{DateOfBirth = new DateTime(1986,1,14), 
                FirstName = "Ahmet",LastName = "Yıldız", NationalityId = "14498910994"});
            Console.ReadLine();
            Console.Clear();
            
            User userOne = new User();
            { 
            userOne.FirstName = "Mahmut";
            userOne.LastName = "Kara";
            userOne.NationalityId = "14554456551";
            }

            User userTwo = new User();
            {
                userTwo.FirstName = "Suleyman";
                userTwo.LastName = "Tuna";
                userTwo.NationalityId = "4125665412";
            }

            User userThree = new User();
            {
                userThree.FirstName = "Hasan";
                userThree.LastName = "Turk";
                userThree.NationalityId = "14554455125";
            }

            userManager.Add(userOne);
            userManager.Remove(userTwo);
            userManager.Uptade(userThree);
            Console.ReadLine();
            Console.Clear();


            ProductManager productManager = new ProductManager();
           

            Product gameOne = new Product();
            {
                gameOne.ProductId = 1;
                gameOne.ProductName = "World Of WarCraft";
                gameOne.UnitInPrice = 350;
                
            }

            Product gameTwo = new Product();
            {
                gameTwo.ProductId = 2;
                gameTwo.ProductName = "Mortal Combat";
                gameTwo.UnitInPrice = 400;

            }

            Product gameThree = new Product();
            {
                gameThree.ProductId = 3;
                gameThree.ProductName = "League of Legends";
                gameThree.UnitInPrice = 450;

            }

            productManager.Add(gameOne);
            productManager.Remove(gameTwo);
            productManager.Uptade(gameThree);
            Console.ReadLine();
            Console.Clear();

            CampaignManager campaignManager = new CampaignManager();

            Campaign campaignOne = new Campaign();
            {
                campaignOne.CampaignId = 10;
                campaignOne.CampaignName = "Pay One Buy Two";
                campaignOne.DiscountRate = 50;
            }

            Campaign campaignTwo = new Campaign();
            {
                campaignTwo.CampaignId = 20;
                campaignTwo.CampaignName = "Special For Boys";
                campaignTwo.DiscountRate = 30;
            }

            Campaign campaignThree = new Campaign();
            {
                campaignThree.CampaignId = 30;
                campaignThree.CampaignName = "Special For Girls";
                campaignThree.DiscountRate = 20;
            }

            campaignManager.Add(campaignOne);
            campaignManager.Remove(campaignTwo);
            campaignManager.Uptade(campaignThree);
            Console.ReadLine();
            Console.Clear();

            OrderManager orderManager = new OrderManager();
            
            
            Order orderOne = new Order();
            orderOne.Id = "156654";
            orderOne.City = "Ankara";
            orderOne.Country = "Turkey";
            orderOne.NationalityId = userOne.NationalityId;
            orderOne.OrderDate = new DateTime(2021, 2, 21);
            orderOne.OrderPrice = gameOne.UnitInPrice - (gameOne.UnitInPrice * campaignOne.DiscountRate) / 100;
            orderManager.Create(orderOne);

        }
    }
}
