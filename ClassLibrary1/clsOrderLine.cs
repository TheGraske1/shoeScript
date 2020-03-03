using System;
namespace ShoeClasses
{
    public class clsOrderLine
    {
        private int mOrderLineID;
        private int mOrderID;
        private int mProductID;
        private int mQuantity;
        private double mPricePerUnit;
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
        public double pricePerUnit
        {
            get
            {
                return mPricePerUnit;
            }
            set
            {
                mPricePerUnit = value;
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
        public bool Find(int orderID)
        {
            mOrderLineID = 4;
            mOrderID = 3;
            mProductID = 5;
            mQuantity = 2;
            mPricePerUnit = 5.99;
            mselectionDescription = "Testing description";

            return true;
        }
    }
    }
