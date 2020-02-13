using System;

namespace ClassLibrary1
{
    public class clsStock
    {
        public bool LimitedEdition { get; set; }
        public DateTime BackInStockDate { get; set; }
        public int QuantityAvailable { get; set; }
        public double Price { get; set; }
        public string StyleName { get; set; }
        public int ProductId { get; set; }
    }
}