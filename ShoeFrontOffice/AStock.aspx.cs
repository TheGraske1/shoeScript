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
        Int32 ProductID = Convert.ToInt32(txtProductId);
        string StyleName = txtStyleName.Text;
        string BackInStockDate = txtBackInStockDate.Text;
        string Price = txtPrice.Text;
        string QuantityAvailable = txtQuantityAvailable.Text;
        AProduct.LimitedEdition = Yes.Checked;

        string Error = "";
        Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
        if (Error == "")
        {
            AProduct.ProductId = ProductID;
            AProduct.StyleName = StyleName;
            AProduct.Price = Convert.ToDouble(Price);
            AProduct.QuantityAvailable = Convert.ToInt32(QuantityAvailable);
            AProduct.BackInStockDate = Convert.ToDateTime(BackInStockDate);

            Session["AProduct"] = AProduct;
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
       
        
        
    }




    protected void Find_Click(object sender, EventArgs e)
    {
        clsStock AProduct = new clsStock();
        Int32 ProductId;
        Boolean found = false;
        ProductId = Convert.ToInt32(txtProductId.Text);
        found = AProduct.Find(ProductId);
        if(found == true)
        {
            txtStyleName.Text = AProduct.StyleName;
            txtPrice.Text = AProduct.Price.ToString();
            txtQuantityAvailable.Text = AProduct.QuantityAvailable.ToString();
            txtBackInStockDate.Text = AProduct.BackInStockDate.ToString();
           

        }
    }
}