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
   //     clsStaff AnStaff = new clsStaff();
 //       AnStaff.name = txtStaffName.Text;
     //   Session["AnStaff"] = AnStaff;
       // Response.Redirect("StaffViewer.aspx");
    }
}