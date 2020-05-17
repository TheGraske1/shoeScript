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
    Int32 ReviewID;

    protected void Page_Load(object sender, EventArgs e)
    {
        /*clsReview AReview = new clsReview();
        AReview = (clsReview)Session["AReview"];
        Response.Write(AReview.ReviewID);              
        */

        ReviewID = Convert.ToInt32(Session["ReviewID"]);
        if(IsPostBack == false)
        {
            if(ReviewID != -1)
            {
                DisplayReview();
            }
        }
    }

    void DisplayReview()
    {
        clsReviewCollection Reviews = new clsReviewCollection();
        Reviews.ThisReview.Find(ReviewID);

        txtReviewID.Text = Reviews.ThisReview.ReviewID.ToString();
        txtProductID.Text = Reviews.ThisReview.ProductID.ToString();
        txtCustomerID.Text = Reviews.ThisReview.CustomerID.ToString();
        txtReviewDate.Text = Reviews.ThisReview.ReviewDate.ToString();
        txtProductRating.Text = Reviews.ThisReview.ProductRating.ToString();
        txtReview.Text = Reviews.ThisReview.Review;
        Yes.Checked = Reviews.ThisReview.VerifiedCustomer;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsReview AReview = new clsReview();
        string ReviewID = txtReviewID.Text;
        string ProductID = txtProductID.Text;
        string CustomerID = txtCustomerID.Text;
        string Review = txtReview.Text;
        string ReviewDate = txtReviewDate.Text;
        string ProductRating = txtProductRating.Text; ;
        string Error = "";

        Error = AReview.Valid(ReviewDate, ProductID, CustomerID, Review, ProductRating);
        if (Error == "")
        {
            AReview.ReviewID = Convert.ToInt32(ReviewID);
            AReview.Review = Review;
            AReview.ReviewDate = Convert.ToDateTime(ReviewDate);
            AReview.ProductID = Convert.ToInt32(ProductID);
            AReview.CustomerID = Convert.ToInt32(CustomerID);
            AReview.ProductRating = Convert.ToInt32(ProductRating);
            AReview.VerifiedCustomer = Yes.Checked;

            clsReviewCollection ReviewList = new clsReviewCollection();

            if(ReviewID == -1)
            {
                ReviewList.ThisReview = AReview;
                ReviewList.Add();
            }

            else
            {
                ReviewList.ThisReview.Find(ReviewID);
                ReviewList.ThisReview = AReview;
                ReviewList.Update();
            }

            Response.Redirect("ReviewList.aspx");
                         
        }

        else
        {
            lblError.Text = Error;
        }
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
