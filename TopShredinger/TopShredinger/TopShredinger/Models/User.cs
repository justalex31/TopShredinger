using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TopShredinger.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool CheckInformation()
        {
            return !Username.Equals("") && !Password.Equals("");
        }
    }
}
