using System;
using System.Collections.Generic;
using System.Text;

namespace ST10083941_PROG6212_ICE1.Classes
{
    class Events
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int NumberOfGuests { get; set; }

        public Events(int userID, string name, string place, DateTime date, DateTime time, int numberOfGuests)
        {
            UserID = userID;
            Name = name;
            Place = place;
            Date = date;
            Time = time;
            NumberOfGuests = numberOfGuests;
        }

    }
}
