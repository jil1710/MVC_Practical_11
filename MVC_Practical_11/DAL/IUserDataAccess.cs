﻿using MVC_Practical_11.Models;
using System.Collections.Generic;

namespace MVC_Practical_11.DAL
{
    public interface IUserDataAccess
    {
        void CreateUser(User user);
        bool DeleteUser(int id);
        User GetUser(int id);
        List<User> GetUsers();
        bool UpdateUser(int id, User user);
    }
}