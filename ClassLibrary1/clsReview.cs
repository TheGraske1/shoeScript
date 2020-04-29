using System;

namespace ClassLibrary1
{
    public class clsReview
    {
        public DateTime ReviewDate { get; set; }
        public int ProductID { get; set; }
        public object Review { get; set; }
        public int ReviewID { get; set; }
        public int ProductRating { get; set; }
        public bool VerifiedCustomer { get; set; }
        public int CustomerID { get; set; }
    }
}