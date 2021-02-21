using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class UserManager :BaseUserManager
    {
        private IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public override void UserValidation(User user)
        {
            if (_userValidationService.CheckUserValidation(user))
            {
                base.UserValidation(user);
            }
            else
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + $" is invalid user. " +
                                  $"Please {user.FirstName + " " + user.LastName} check your information and try again later. ");
             
            }
            
        }

        public override void Add(User user)
        {
            Console.WriteLine("User is added in system. " 
                              + user.FirstName + " " + user.LastName + " his nationalityId is " + user.NationalityId +".");
            
        }

        public override void Remove(User user)
        {
            Console.WriteLine($"{user.FirstName + " " + user.LastName + " "} " +
                              $"is removed from the system. ");

        }

        public override void Uptade(User user)
        {
            Console.WriteLine("User is updated on the system. " + 
                              $"His name and surname is changed as {user.FirstName + " " + user.LastName + "."} " );
        }
    }
}
