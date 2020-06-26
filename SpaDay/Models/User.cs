using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int Id { get; }
        private static int nextId = 1;
        public DateTime SignUpTime { get; }

        public User()
        {
            Id = nextId;
            nextId++;
            SignUpTime = DateTime.Now;
        }

        public User(string username, string email, string password) : this()
        {
            Username = username;
            Email = email;
            Password = password;
        }
        public override string ToString()
        {
            return Username;
        }

        public override bool Equals(object obj)
        {
            return obj is User @user && Id == @user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
