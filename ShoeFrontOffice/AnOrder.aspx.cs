using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        //Response.Write(AnOrder.orderID);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string StaffID = intStaffID.Text;
        string CustomerId = intCustomerID.Text;
        string Price = floatPrice.Text;
        string Address = stringAddress.Text;
        string OrderID = intOrderID.Text;
        string Date = dateOrdered.Text;
        string Paid = boolPaid.Text;
        string Error = "";
        Error = AnOrder.Valid(Date, Paid, Price, StaffID, CustomerId, Address);
        if (Error == "")
        {
            AnOrder.orderID = Convert.ToInt32(intOrderID.Text);
            AnOrder.staffID = Convert.ToInt32(intStaffID.Text);
            AnOrder.totalPrice = Convert.ToDouble(floatPrice.Text);
            AnOrder.deliveryAddress = stringAddress.Text;
            AnOrder.dateOrdered = Convert.ToDateTime(dateOrdered.Text);
            AnOrder.paid = boolPaid.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
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
        string orderLineID = intOrderLine.Text;
        string orderID = OrderIDFind.Text;
        string productID = ProductIDFind.Text;
        string selectionDescription = SelectionDescriptionFind.Text;
        string quantity = QuantityList.Text;
        string Error = "";
        Error = AnOrderLine.Valid(orderID, productID, quantity, selectionDescription);
        if (Error == "")
        {
            AnOrderLine.orderLineID = Convert.ToInt32(intOrderLine.Text);
            AnOrderLine.orderID = Convert.ToInt32(OrderIDFind.Text);
            AnOrderLine.productID = Convert.ToInt32(ProductIDFind.Text);
            AnOrderLine.selectionDescription = SelectionDescriptionFind.Text;
            AnOrderLine.quantity = Convert.ToInt32(QuantityList.Text);
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            OrderLineList.ThisOrderLine = AnOrderLine;
            OrderLineList.Add();
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
   


    