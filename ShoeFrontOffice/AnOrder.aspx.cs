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
        AnOrderLine.pricePerUnit = Convert.ToInt32(floatPriceUnit.Text);
        AnOrderLine.selectionDescription = stringSelection.Text;
        AnOrder.paid = boolPaid.Checked;
        AnOrderLine.quantity = Convert.ToInt32(DropDownList1.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }
}
   


    