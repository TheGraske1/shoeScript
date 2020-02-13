using System;

namespace ClassLibrary1
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public string name { get; set; }
        public string phoneNumber { get; set; }
        public DateTime joinedDate { get; set; }
        public double salary { get; set; }
        public bool admin { get; set; }
    }
}