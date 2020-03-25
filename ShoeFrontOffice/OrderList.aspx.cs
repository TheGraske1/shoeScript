using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        ShoeClasses.clsOrderCollection Orders = new ShoeClasses.clsOrderCollection();
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "orderID";
        lstOrders.DataTextField = "deliveryAddress";
        lstOrders.DataBind();

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["orderID"] = -1;
        Response.Redirect("AnOrder.aspx");
    }
}