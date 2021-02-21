using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IUserService
    {
        void UserValidation(User user);
        void Add(User user);
        void Remove(User user);
        void Uptade(User user);

    }
}
