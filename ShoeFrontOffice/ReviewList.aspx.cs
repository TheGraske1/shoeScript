using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;


public partial class ReviewList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayReviews();
        }
    }

    void DisplayReviews()
    {
        ShoeClasses.clsReviewCollection Reviews = new ShoeClasses.clsReviewCollection();
        lstReviewList.DataSource = Reviews.ReviewList;
        lstReviewList.DataValueField = "ReviewID";
        lstReviewList.DataTextField = "ReviewDate";
        lstReviewList.DataBind();

    }

    protected void lstReviewList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ReviewID"] = -1;
        Response.Redirect("AReview.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ReviewID;

        if(lstReviewList.SelectedIndex != -1)
        {
            ReviewID = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["ReviewID"] = ReviewID;
            Response.Redirect("DeleteReview.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ReviewID;

        if (lstReviewList.SelectedIndex != -1)
        {
            ReviewID = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["ReviewID"] = ReviewID;
            Response.Redirect("AReview.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}