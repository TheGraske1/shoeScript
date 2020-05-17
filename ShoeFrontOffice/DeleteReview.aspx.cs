using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteReview : System.Web.UI.Page
{
    Int32 ReviewID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReviewID = Convert.ToInt32(Session["ReviewID"]);
    }




    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsReviewCollection Reviews = new clsReviewCollection();
        Reviews.ThisReview.Find(ReviewID);
        Reviews.Delete();
        Response.Redirect("ReviewList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}