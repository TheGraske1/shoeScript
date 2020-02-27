using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

public partial class AnStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.name);
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        AnStaff.name = txtStaffName.Text;
        AnStaff.phoneNumber = txtPhoneNum.Text;
        AnStaff.salary = Convert.ToDouble(txtSalary.Text);
        AnStaff.joinedDate = Convert.ToDateTime(txtJoinedDate.Text);
        AnStaff.admin = chckAdmin.Checked;
        Session["AnStaff"] = AnStaff;
        Response.Write("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        int StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AnStaff.Find(StaffId);
        if (Found == true)
        {
            txtStaffName.Text = AnStaff.name;
            txtPhoneNum.Text = AnStaff.phoneNumber;
            txtSalary.Text = AnStaff.salary.ToString();
            txtJoinedDate.Text = AnStaff.joinedDate.ToString();
        }
    }
}