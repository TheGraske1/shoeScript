using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;
using ClassLibrary1;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AProduct = new clsStock();
        AProduct = (clsStock)Session["AProduct"];
        Response.Write(AProduct.ProductId);
    }
}