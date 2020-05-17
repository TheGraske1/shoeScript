using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteProduct : System.Web.UI.Page
{
    Int32 ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStockCollection Products = new clsStockCollection();
        Products.ThisProduct.Find(ProductId);
        Products.Delete();
        Response.Redirect("ProductList.aspx");
    }
}