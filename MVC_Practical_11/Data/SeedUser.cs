using MVC_Practical_11.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MVC_Practical_11.Data
{
    public static class UserData
    {
        public static List<User> Users { get; set; }

        static UserData()
        {
            Users = new List<User>()
            {
                new User() {Id = 1, Name ="Jil",DOB = DateTime.Now.ToString("yyyy-MM-dd") ,Address="Anand"},
                new User() {Id = 2, Name ="Janvi",DOB = DateTime.Now.ToString("yyyy-MM-dd") ,Address="Anand"},
                new User() {Id = 3, Name ="Jay",DOB = DateTime.Now.ToString("yyyy-MM-dd") ,Address="Rajkot"}
            };
        }
    }
}