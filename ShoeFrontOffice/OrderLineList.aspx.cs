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
}