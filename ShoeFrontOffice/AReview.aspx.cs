using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using ShoeClasses;


public partial class AReview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsReview AReview = new clsReview();

        AReview = (clsReview)Session["AReview"];

        Response.Write(AReview.ReviewID);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsReview AReview = new clsReview();
        {
            AReview.ReviewID = Convert.ToInt32(txtReviewID.Text);
            AReview.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AReview.ProductID = Convert.ToInt32(txtProductID.Text);
            AReview.ReviewDate = Convert.ToDateTime(txtReviewDate.Text);
            AReview.Review = txtReview.Text;
            // AReview.ProductRating = 
            
                   
            
        }

        Session["AReview"] = AReview;

        Response.Redirect("ReviewViewer.aspx");
    }
    protected void VerifiedCustomer_CheckedChanged(object sender, EventArgs e)
    {

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsReview AReview = new clsReview();
        Int32 ReviewID;
        Boolean Found = false;
        ReviewID = Convert.ToInt32(txtReviewID.Text);
        Found = AReview.Find(ReviewID);

        if (Found == true)
        {
            txtReviewID.Text = AReview.ReviewID.ToString();
            txtProductID.Text = AReview.ProductID.ToString();
            txtCustomerID.Text = AReview.CustomerID.ToString();
            txtReviewDate.Text = AReview.ReviewDate.ToString();
            txtProductRating.Text = AReview.ProductRating.ToString();
            txtReview.Text = AReview.Review;
        }
    }
}
