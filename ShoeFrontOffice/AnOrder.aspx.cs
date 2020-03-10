using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.orderID);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrder.orderID = Convert.ToInt32(intOrderID.Text);
        AnOrder.staffID = Convert.ToInt32(intStaffID.Text);
        AnOrder.totalPrice = Convert.ToDouble(floatPrice.Text);
        AnOrder.deliveryAddress = stringAddress.Text;
        AnOrder.dateOrdered = Convert.ToDateTime(dateOrdered.Text);
        AnOrderLine.orderLineID = Convert.ToInt32(intOrderLine.Text);
        AnOrderLine.productID = Convert.ToInt32(intProduct.Text);
        AnOrderLine.selectionDescription = stringSelection.Text;
        AnOrder.paid = boolPaid.Checked;
        AnOrderLine.quantity = Convert.ToInt32(DropDownList1.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }

    protected void Find_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        clsOrderLine AnOrderLine = new clsOrderLine();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(intOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if(Found == true)
        {
            intOrderID.Text = Convert.ToString(AnOrder.orderID);
            intStaffID.Text = Convert.ToString(AnOrder.staffID);
            floatPrice.Text = Convert.ToString(AnOrder.totalPrice);
            stringAddress.Text = AnOrder.deliveryAddress;
            dateOrdered.Text = Convert.ToString(AnOrder.dateOrdered);
            intOrderLine.Text = Convert.ToString(AnOrderLine.orderLineID);
            intProduct.Text = Convert.ToString(AnOrderLine.productID);
            stringSelection.Text = AnOrderLine.selectionDescription;
            boolPaid.Text = Convert.ToString(AnOrder.paid);
            DropDownList1.Text = Convert.ToString(AnOrderLine.quantity);



        }
    }
}
   


    