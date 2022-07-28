using System;
using System.Collections.Generic;
using System.Text;

namespace ST10083941_PROG6212_ICE1.Classes
{
    class Users
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public Users(int userID, string username, string password)
        {
            UserID = userID;
            Username = username;
            Password = password;
        }
    }
}
