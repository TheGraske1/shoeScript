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
    //Int32 ReviewID;

    protected void Page_Load(object sender, EventArgs e)
    {
        clsReview AReview = new clsReview();
        AReview = (clsReview)Session["AReview"];
        Response.Write(AReview.ReviewID);              

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsReview AReview = new clsReview();
        //string ReviewID = txtReviewID.Text;
        string ProductID = txtProductID.Text;
        string CustomerID = txtCustomerID.Text;
        string Review = txtReview.Text;
        string ReviewDate = txtReviewDate.Text;
        string ProductRating = txtProductRating.Text; ;
        string Error = "";

        Error = AReview.Valid(ReviewDate, ProductID, CustomerID, Review, ProductRating);
        if (Error == "")
        {
            //AReview.ReviewID = Convert.ToInt32(ReviewID);
            AReview.Review = Review;
            AReview.ReviewDate = Convert.ToDateTime(ReviewDate);
            AReview.ProductID = Convert.ToInt32(ProductID);
            AReview.CustomerID = Convert.ToInt32(CustomerID);
            AReview.ProductRating = Convert.ToInt32(ProductRating);
                        
            Session["AReview"] = AReview;
            Response.Write("ReviewViewer.aspx");                    
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
