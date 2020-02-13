using System;

namespace ClassLibrary1
{
    public class clsOrder
    {
        

        public DateTime dateOrdered { get; set; }
        public bool Paid { get; set; }
        public string deliveryAddress { get; set; }
        public object orderID { get; set; }
        public int customerID { get; set; }
        public int staffID { get; set; }
        public double totalPrice { get; set; }
    }
}