using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

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
        Int32 StaffId = Convert.ToInt32(txtStaffId.Text);
        string StaffName = txtStaffName.Text;
        string PhoneNumber = txtPhoneNum.Text;
        string Salary = txtSalary.Text;
        string JoinedDate = txtJoinedDate.Text;

        string Error = "";
        Error = AnStaff.Valid(StaffName, PhoneNumber, Salary, JoinedDate);
        if(Error == "")
        {
            AnStaff.staffid = StaffId;
            AnStaff.name = StaffName;
            AnStaff.phoneNumber = PhoneNumber;
            AnStaff.salary = Convert.ToDouble(Salary);
            AnStaff.joinedDate = Convert.ToDateTime(JoinedDate);

            Session["AnStaff"] = AnStaff;
            Response.Write("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        string staffName = txtStaffName.Text;
        string phoneNum = txtPhoneNum.Text;
        string salary = txtSalary.Text;
        string joinedDate = txtJoinedDate.Text;
        string Error = "";
        Error = AnStaff.Valid(staffName, phoneNum, salary, joinedDate);
        if(Error == "")
        {
            AnStaff.name = staffName;
            AnStaff.phoneNumber = phoneNum;
            AnStaff.salary = Convert.ToDouble(salary);
            AnStaff.joinedDate = Convert.ToDateTime(joinedDate);
            Session["AnStaff"] = AnStaff;
            Response.Write("StaffView.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


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