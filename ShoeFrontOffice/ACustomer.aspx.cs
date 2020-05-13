using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ShoeClasses;

public partial class Customer : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        /* clsCustomer ACustomer = new clsCustomer();
         ACustomer = (clsCustomer)Session["ACustomer"];
         Response.Write(ACustomer.Name);*/

        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if(CustomerID != -1)
            {
                DisplayCustomer();
            }
        }

    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(CustomerID);
        txtName.Text = Customer.ThisCustomer.Name.ToString();
        txtAddress.Text = Customer.ThisCustomer.Address.ToString();
        txtDatecreated.Text = Customer.ThisCustomer.DateCreated.ToString();
        chkRegistered.Checked = Customer.ThisCustomer.Registered;
        txtRegistered.Text = Customer.ThisCustomer.Registered.ToString();
        txtBalance.Text = Customer.ThisCustomer.Balance.ToString();


    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        string CustomerID = txtCustomerID.Text;

        string Name = txtName.Text;

        string Address = txtAddress.Text;

        string DateCreated = txtDatecreated.Text;

        string Registered = txtRegistered.Text;

        string Balance = txtBalance.Text;

        string Error = "";
        Error = ACustomer.Valid(Name, Address, DateCreated, Registered, Balance);
        if (Error == "")
        {
            ACustomer.Name = Name;
            ACustomer.Address = Address;
            ACustomer.DateCreated = Convert.ToDateTime(DateCreated);
            ACustomer.Registered = chkRegistered.Checked;
            ACustomer.Registered = Convert.ToBoolean(Registered);//chkRegistered.Checked;
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
            chkRegistered.Checked = ACustomer.Registered;
            txtRegistered.Text = ACustomer.Registered.ToString();
            txtBalance.Text = ACustomer.Balance.ToString();
        }
    }


    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        //string CustomerID = txtCustomerID.Text;

        string Name = txtName.Text;

        string Address = txtAddress.Text;

        string DateCreated = txtDatecreated.Text;

        string Registered = txtRegistered.Text;

        string Balance = txtBalance.Text;

        string Error = "";
        Error = ACustomer.Valid(Name, Address, DateCreated, Registered, Balance);
        if (Error == "")
        {
            ACustomer.CustomerID = CustomerID;
            ACustomer.Name = Name;
            ACustomer.Address = Address;
            ACustomer.DateCreated = Convert.ToDateTime(DateCreated);
            ACustomer.Registered = chkRegistered.Checked;
            ACustomer.Registered = Convert.ToBoolean(Registered);
            ACustomer.Balance = Convert.ToDouble(Balance);

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if(CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();

            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }



    }
}