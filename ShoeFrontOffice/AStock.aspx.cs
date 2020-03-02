using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;
using ClassLibrary1;

public partial class AStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AProduct = new clsStock();
        AProduct = (clsStock)Session["AProduct"];
        Response.Write(AProduct.ProductId);
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        clsStock AProduct = new clsStock();
        AProduct.ProductId = Convert.ToInt32(txtProductId);
        AProduct.StyleName = txtStyleName.Text;
        AProduct.QuantityAvailable = txtQuantityAvailable.Text;
        AProduct.Price = txtPrice.Text;

        Response.Redirect("StockViewer.aspx");

    }
}