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
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            if(ProductId != -1)
            {
                DisplayProduct();
            }
        }
    }
    void DisplayProduct()
    {
        clsStockCollection Products = new clsStockCollection();
        Products.ThisProduct.Find(ProductId);
        txtProductId.Text = Products.ThisProduct.ProductId.ToString();
        txtStyleName.Text = Products.ThisProduct.StyleName;
        txtQuantityAvailable.Text = Products.ThisProduct.QuantityAvailable.ToString();
        txtPrice.Text = Products.ThisProduct.Price.ToString();
        txtBackInStockDate.Text = Products.ThisProduct.BackInStockDate.ToString();
        chkLimitedEdition.Checked = Products.ThisProduct.LimitedEdition;
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        clsStock AProduct = new clsStock();
        string ProductID = txtProductId.Text;
        string StyleName = txtStyleName.Text;
        string BackInStockDate = txtBackInStockDate.Text;
        string Price = txtPrice.Text;
        string QuantityAvailable = txtQuantityAvailable.Text;
       

        string Error = "";
        Error = AProduct.Valid(StyleName, BackInStockDate, Price, QuantityAvailable);
        if (Error == "")
        {
            AProduct.ProductId = Convert.ToInt32(ProductID);
            AProduct.StyleName = StyleName;
            AProduct.Price = Convert.ToDouble(Price);
            AProduct.QuantityAvailable = Convert.ToInt32(QuantityAvailable);
            AProduct.BackInStockDate = Convert.ToDateTime(BackInStockDate);
            AProduct.LimitedEdition = chkLimitedEdition.Checked;
            clsStockCollection ProductList = new clsStockCollection();
            if(Convert.ToInt32(ProductID) == -1)
            {
                ProductList.ThisProduct = AProduct;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(ProductId);
                ProductList.ThisProduct = AProduct;
                ProductList.Update();
            }
            
            Response.Redirect("ProductList.aspx");
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