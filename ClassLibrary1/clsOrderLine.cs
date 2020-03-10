using System;
namespace ShoeClasses
{
    public class clsOrderLine
    {
        private int mOrderLineID;
        private int mOrderID;
        private int mProductID;
        private int mQuantity;
        private string mselectionDescription;
       
        public int orderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }

        public int orderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        public int productID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        public int quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
       
        public string selectionDescription
        {
            get
            {
                return mselectionDescription;
            }
            set
            {
                mselectionDescription = value;
            }
        }
        public bool Find(int orderLineID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@orderLineID", orderLineID);
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            if (DB.Count == 1)
            {
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["orderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["orderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["productID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["quantity"]);
                mselectionDescription = Convert.ToString(DB.DataTable.Rows[0]["selectionDescription"]);
                

                return true;
            }
            else
            {
                return false;
            }
        }
        public string Valid(string orderID, string product, string quantity, string selection)
        {
            return "";
        }
    }
    }
