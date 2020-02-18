using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;


public partial class Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        ACustomer = (clsCustomer)Session["ACustomer"];

        Response.Write(ACustomer.name);
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //clsCustomer ACustomer = new clsCustomer();
        //ACustomer.name = txtName.Text;
        //Session["ACustomer"] = ACustomer;
        //Response.Redirect("CustomerViewer.aspx");

    }
}