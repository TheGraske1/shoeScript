using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
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
}