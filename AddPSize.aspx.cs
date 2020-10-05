using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class AddPSize : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button click adds new P_Size to database 
        protected void AddPSize_Click(object sender, EventArgs e)
        {
            //Conversion from String to Integer 
            int sizeID = Convert.ToInt32(SizeID.Value);
            int psize = Convert.ToInt32(PSize.Value);

            //Service function to add P_Size to database
            string P_Size = SR.Addpsize(sizeID, psize);

            //if adding is successful
            if (P_Size.Equals("added"))
            {
                //redirect to the home page 
                Response.Redirect("Home.aspx");
            }
            //If P_Size was not added to database 
            else if (P_Size.Equals("not added"))
            {
                //Display error message to admin  
                error.Text = "Product size type added to database. ";
                error.Visible = true;
            }
            //If P_Size already exists
            else if (P_Size.Equals("error"))
            {
                //Display error message to admin 
                error.Text = "MProduct sizeask type already exists. ";
                error.Visible = true;
            }
        }

        //Button click edits details of exising product 
        //Button click redirects to EditProduct.aspx page 
        protected void EditPSize_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditMaskType.aspx");
        }
    }
}