using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderID;
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["orderID"]);
        OrderLineID = Convert.ToInt32(Session["orderLineID"]);
        if (IsPostBack == false)
        {
            if(OrderID != -1)
            {
                DisplayOrder();
            }
            if (OrderLineID != -1)
            {
                DisplayOrderLine();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        intOrderID.Text = OrderBook.ThisOrder.orderID.ToString();
        intStaffID.Text = OrderBook.ThisOrder.staffID.ToString();
        intCustomerID.Text = OrderBook.ThisOrder.customerID.ToString();
        boolPaid.Checked = OrderBook.ThisOrder.paid;
        stringAddress.Text = OrderBook.ThisOrder.deliveryAddress;
        dateOrdered.Text = OrderBook.ThisOrder.dateOrdered.ToString();
        floatPrice.Text = OrderBook.ThisOrder.totalPrice.ToString();
    }
    void DisplayOrderLine()
    {
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        OrderLineBook.ThisOrderLine.Find(OrderLineID);
        intOrderLine.Text = OrderLineBook.ThisOrderLine.orderLineID.ToString();
        OrderIDFind.Text = OrderLineBook.ThisOrderLine.orderID.ToString();
        ProductIDFind.Text = OrderLineBook.ThisOrderLine.productID.ToString();
        SelectionDescriptionFind.Text = OrderLineBook.ThisOrderLine.selectionDescription;
        QuantityList.Text = OrderLineBook.ThisOrderLine.quantity.ToString();
    }

    protected void btnOKOrder_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string StaffID = intStaffID.Text;
        string CustomerId = intCustomerID.Text;
        string Price = floatPrice.Text;
        string Address = stringAddress.Text;
        string Date = dateOrdered.Text;
        string Error = "";
        Error = AnOrder.Valid(Date, Price, StaffID, CustomerId, Address);
        if (Error == "")
        {
            AnOrder.customerID = Convert.ToInt32(intCustomerID.Text);
            AnOrder.staffID = Convert.ToInt32(intStaffID.Text);
            AnOrder.totalPrice = Convert.ToDouble(floatPrice.Text);
            AnOrder.deliveryAddress = stringAddress.Text;
            AnOrder.dateOrdered = Convert.ToDateTime(dateOrdered.Text);
            AnOrder.paid = boolPaid.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else{
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            Label2.Text = Error;
        }
    }
    protected void btnOKOrderLine_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        string orderID = OrderIDFind.Text;
        string productID = ProductIDFind.Text;
        string selectionDescription = SelectionDescriptionFind.Text;
        string quantity = QuantityList.Text;
        string Error = "";
        Error = AnOrderLine.Valid(orderID, productID, quantity, selectionDescription);
        if (Error == "")
        {
            AnOrderLine.orderID = Convert.ToInt32(OrderIDFind.Text);
            AnOrderLine.productID = Convert.ToInt32(ProductIDFind.Text);
            AnOrderLine.selectionDescription = SelectionDescriptionFind.Text;
            AnOrderLine.quantity = Convert.ToInt32(QuantityList.Text);
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            if (OrderLineID == -1)
            {
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Add();
            }
            else
            {
                OrderLineList.ThisOrderLine.Find(OrderLineID);
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Update();
            }
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
            Label2.Text = Error;
        }
    }

    protected void FindOrder_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(intOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            intOrderID.Text = Convert.ToString(AnOrder.orderID);
            intCustomerID.Text = Convert.ToString(AnOrder.customerID);
            intStaffID.Text = Convert.ToString(AnOrder.staffID);
            floatPrice.Text = Convert.ToString(AnOrder.totalPrice);
            stringAddress.Text = AnOrder.deliveryAddress;
            dateOrdered.Text = Convert.ToString(AnOrder.dateOrdered.Date);
            boolPaid.Text = Convert.ToString(AnOrder.paid);
        }
    }
        protected void FindOrderLine_Click(object sender, EventArgs e)
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 OrderLineID;
            Boolean Found = false;
            OrderLineID = Convert.ToInt32(intOrderLine.Text);
            Found = AnOrderLine.Find(OrderLineID);
            if (Found == true)
            {
                intOrderLine.Text = Convert.ToString(AnOrderLine.orderLineID);
                OrderIDFind.Text = Convert.ToString(AnOrderLine.orderID);
                ProductIDFind.Text = Convert.ToString(AnOrderLine.productID);
                SelectionDescriptionFind.Text = AnOrderLine.selectionDescription;
                QuantityList.Text = Convert.ToString(AnOrderLine.quantity);
            }
        }
}
   


    