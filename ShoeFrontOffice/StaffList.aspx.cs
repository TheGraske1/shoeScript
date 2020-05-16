using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class StaffList : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayNames();
        }
    }

    void DisplayNames()
    {
        ShoeClasses.clsStaffCollection Staff = new ShoeClasses.clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;

        lstStaffList.DataValueField = "staffid";
        lstStaffList.DataTextField = "name";

        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("AnStaff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if(lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["AnStaff"] = StaffId;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if(lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("AnStaff.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByPhoneNumber(txtPhoneNum.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "PhoneNumber";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByPhoneNumber("");
        txtPhoneNum.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "PhoneNumber";
        lstStaffList.DataBind();
    }
}