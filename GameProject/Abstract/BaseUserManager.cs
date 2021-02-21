using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        public virtual void UserValidation(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + "  is a valid user ");

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

    }
}
