using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class AnStaff : System.Web.UI.Page
{
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            if(StaffId != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffId);
        txtStaffId.Text = StaffBook.ThisStaff.staffid.ToString();
        txtStaffName.Text = StaffBook.ThisStaff.name;
        txtPhoneNum.Text = StaffBook.ThisStaff.phoneNumber;
        txtSalary.Text = StaffBook.ThisStaff.salary.ToString();
        txtJoinedDate.Text = StaffBook.ThisStaff.joinedDate.ToString();
        chckAdmin.Checked = StaffBook.ThisStaff.admin;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
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
            AnStaff.admin = chckAdmin.Checked;

            clsStaffCollection StaffList = new clsStaffCollection();
            if(StaffId == -1)
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
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