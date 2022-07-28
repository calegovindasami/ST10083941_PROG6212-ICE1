using System;
using System.Collections.Generic;
using System.Text;

namespace ST10083941_PROG6212_ICE1.Classes
{
    class People
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public People(int userID, string fullName, int age, string gender)
        {
            UserID = userID;
            FullName = fullName;
            Age = age;
            Gender = gender;
        }
    }
}
