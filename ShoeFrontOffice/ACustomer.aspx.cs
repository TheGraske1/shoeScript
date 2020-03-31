using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        string CustomerID = txtCustomerID.Text;

        string Name = txtName.Text;

        string Address = txtAddress.Text;

        string DateCreated = txtDatecreated.Text;

        ACustomer.Registered = chkRegistered.Checked;

        string Registered = txtRegistered.Text;

        string Balance = txtBalance.Text;

        string Error = "";
        Error = ACustomer.Valid(Name, Address, DateCreated, Registered, Balance);
        if (Error == "")
        {
            ACustomer.Name = Name;
            ACustomer.Address = Address;
            ACustomer.DateCreated = Convert.ToDateTime(DateCreated);
            ACustomer.Registered = chkRegistered.Checked;//Convert.ToBoolean(Registered);
            ACustomer.Balance = Convert.ToDouble(Balance);

            Session["ACustomer"] = ACustomer;
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }




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


    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        string CustomerID = txtCustomerID.Text;

        string Name = txtName.Text;

        string Address = txtAddress.Text;

        string DateCreated = txtDatecreated.Text;

        ACustomer.Registered = chkRegistered.Checked;

        string Registered = txtRegistered.Text;

        string Balance = txtBalance.Text;

        string Error = "";
        Error = ACustomer.Valid(Name, Address, DateCreated, Registered, Balance);
        if (Error == "")
        {
            ACustomer.Name = Name;
            ACustomer.Address = Address;
            ACustomer.DateCreated = Convert.ToDateTime(DateCreated);
            ACustomer.Registered = chkRegistered.Checked; //Convert.ToBoolean(Registered);
            ACustomer.Balance = Convert.ToDouble(Balance);

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = ACustomer;
            CustomerList.Add();

            
            Response.Write("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }




        

    }
}