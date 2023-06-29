
using MVC_Practical_11_Partial_View.Data;
using MVC_Practical_11_Partial_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Practical_11_Partial_View.DAL
{
    public class UserDataAccess : IUserDataAccess
    {
        public List<User> GetUsers()
        {
            return UserData.Users.ToList();
        }

        public User GetUser(int id)
        {
            return UserData.Users.FirstOrDefault(x => x.Id == id);
        }


        public bool UpdateUser(int id, User user)
        {
            var user1 = UserData.Users.Find(e => e.Id == id);

            if (user1 != null)
            {
                user1.Name = user.Name;
                user1.Address = user.Address;
                user1.DOB = user.DOB;
                return true;
            }

            return false;

        }

        public bool DeleteUser(int id)
        {
            return UserData.Users.Remove(GetUser(id));
        }

        public void CreateUser(User user)
        {
            UserData.Users.Add(user);
        }

    }
}