using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Data
{
    public class UserData
    {
        static private Dictionary<int, User> Users = new Dictionary<int, User>();

        //Get all users
        public static IEnumerable<User> GetAll()
        {
            return Users.Values;
        }

        //Add user
        public static void Add(User newUser)
        {
            Users.Add(newUser.Id, newUser);
        }

        //Remove user
        public static void Remove(int id)
        {
            Users.Remove(id);
        }

        //Get user by Id
        public static User GetById(int id)
        {
            return Users[id];
        }
    }
}
