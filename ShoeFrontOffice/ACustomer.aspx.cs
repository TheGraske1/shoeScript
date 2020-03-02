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
       /* clsCustomer ACustomer = new clsCustomer();
        ACustomer.name = txtName.Text;

        ACustomer.Address = txtAddress.Text;

        ACustomer.createdDate = Convert.ToDateTime(txtDatecreated.text);

        ACustomer.account = txtRegistered.text;

        ACustomer.balance = txtBalance.text;



        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");*/

    }
}