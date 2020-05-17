using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

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
        

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        Int32 OrderID;
        if (lstOrders.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrders.SelectedValue);
            Session["orderID"] = OrderID;
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete form the list";
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrders.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrders.SelectedValue);
            Session["orderID"] = OrderID;
            Response.Redirect("DeleteOrders.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByDeliveryAddress(txtFilter.Text);
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "orderID";
        lstOrders.DataTextField = "deliveryAddress";
        lstOrders.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByDeliveryAddress("");
        txtFilter.Text = "";
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "orderID";
        lstOrders.DataTextField = "deliveryAddress";
        lstOrders.DataBind();
    }

    protected void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}