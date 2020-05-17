using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class ReviewViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsReview AReview = new clsReview();

        AReview = (clsReview)Session["AReview"];

        Response.Write(AReview.ReviewID);
            
    }
}