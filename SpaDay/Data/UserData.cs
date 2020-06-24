using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Data
{
    public class UserData
    {
        //store user data
        private static Dictionary<int, User> Users = new Dictionary<int, User>();

        //add users
        public static void Add(User newUser)
        {
            Users.Add(newUser.Id, newUser);
        }

        //retreive all users
        public static IEnumerable<User> GetAll()
        {
            return Users.Values;
        }

        //retreive a single user
        public static User GetById(int id)
        {
            return Users[id];
        }

        //remove a user
        public static void Remove(int id)
        {
            Users.Remove(id);
        }

    }
}
