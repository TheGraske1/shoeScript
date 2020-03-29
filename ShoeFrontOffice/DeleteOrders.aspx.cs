using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class DeleteOrders : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["orderID"]);
        TextBox1.Text = Convert.ToString(Session["orderID"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder.Find(OrderID);
        Orders.Delete();
        Response.Redirect("OrderList.aspx");
    }
}