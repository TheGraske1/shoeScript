using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }
    void DisplayProducts()
    {
        ClassLibrary1.clsStockCollection Products = new ClassLibrary1.clsStockCollection();
        lstProductList.DataSource = Products.ProductList;
        lstProductList.DataValueField = "ProductId";
        lstProductList.DataTextField = "StyleName";
        lstProductList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductId"] = -1;
        Response.Redirect("AStock.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        if (lstProductList.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstProductList.SelectedValue);
            Session["ProductId"] = ProductId;
            Response.Redirect("DeleteProduct.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductId;
        if (lstProductList.SelectedIndex != -1)
        {
            ProductId = Convert.ToInt32(lstProductList.SelectedValue);
            Session["ProductId"] = ProductId;
            Response.Redirect("AStock.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to selete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Products = new clsStockCollection();
        Products.ReportByStyleName(txtFilter.Text);
        lstProductList.DataSource = Products.ProductList;
        lstProductList.DataValueField = "ProductId";
        lstProductList.DataTextField = "StyleName";
        lstProductList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Products = new clsStockCollection();
        Products.ReportByStyleName("");
        txtFilter.Text = "";
        lstProductList.DataSource = Products.ProductList;
        lstProductList.DataValueField = "ProductId";
        lstProductList.DataTextField = "StyleName";
        lstProductList.DataBind();
    }
}