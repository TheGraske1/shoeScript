using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using ShoeClasses;

public partial class Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        ACustomer = (clsCustomer)Session["ACustomer"];

        Response.Write(ACustomer.Name);
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        ACustomer.CustomerID =Convert.ToInt32( txtCustomerID.Text);

        ACustomer.Name = txtName.Text;

        ACustomer.Address = txtAddress.Text;

        ACustomer.DateCreated = Convert.ToDateTime(txtDatecreated.Text);

        ACustomer.Registered = chkRegistered.Checked;

        ACustomer.Balance =Convert.ToDouble( txtBalance.Text);




        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);

        if (Found == true)
        {
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtName.Text = ACustomer.Name;
            txtAddress.Text = ACustomer.Address;
            txtDatecreated.Text = ACustomer.DateCreated.ToString();
            txtRegistered.Text = ACustomer.Registered.ToString();
            txtBalance.Text = ACustomer.Balance.ToString();
        }
    }

}