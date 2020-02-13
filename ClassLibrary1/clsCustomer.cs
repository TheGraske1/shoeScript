using System;

namespace ClassLibrary1
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public string name { get; set; }
        public string Address { get; set; }
        public DateTime createdDate { get; set; }
        public bool account { get; set; }
        public double balance { get; set; }
    }
}