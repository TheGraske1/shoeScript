namespace ClassLibrary1
{
    public class clsOrderLine
    {
        public clsOrderLine()
        {
        }

        public int orderLineID { get; set; }
        public int orderID { get; set; }
        public int productID { get; set; }
        public int quantity { get; set; }
        public double pricePerUnit { get; set; }
        public string selectionDescription { get; set; }
    }
}