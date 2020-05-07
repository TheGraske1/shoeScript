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

        Response.Write(ACustomer.Name);
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        ACustomer.CustomerID = txtCustomerID.text;


        ACustomer.Name = txtName.Text;

        ACustomer.Address = txtAddress.Text;

        ACustomer.DateCreated = Convert.ToDateTime(txtDatecreated.text);

        ACustomer.Registered = txtRegistered.text;

        ACustomer.Balance = txtBalance.text;



        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
       CustomerID = Convert.ToInt32(txtCustomerID.text);
        Found = ACustomer.Find(Customer);

        if (Found == true)
        {
            txtCustomerID.text = ACustomer.CustomerID;
            txtName.text = ACustomer.Name;
            txtAddress = ACustomer.Address;
            txtDatecreated = ACustomer.DateCreated;
           txtRegistered = ACustomer.Registered;
            txtBalance = ACustomer.Balance;
        }
    }

}