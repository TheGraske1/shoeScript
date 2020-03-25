using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrderLines();
        }
    }

    void DisplayOrderLines()
    {
        ShoeClasses.clsOrderLineCollection OrderLines = new ShoeClasses.clsOrderLineCollection();
        lstOrderLine.DataSource = OrderLines.OrderLineList;
        lstOrderLine.DataValueField = "orderID";
        lstOrderLine.DataTextField = "deliveryAddress";
        lstOrderLine.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["orderLineID"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLine.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLine.SelectedValue);
            Session["orderLineID"] = OrderLineID;
            Response.Redirect("DeleteOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}