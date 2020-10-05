using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class AddSize : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button click adds new size to database 
        protected void AddSize_Click(object sender, EventArgs e)
        {
            //Service function to add size to database
            string size = SR.Addsize(Name.Value, Dimension.Value);

            //if adding is successful
            if (size.Equals("added"))
            {
                //redirect to the home page 
                Response.Redirect("Home.aspx");
            }
            //If size was not added to database 
            else if (size.Equals("not added"))
            {
                //Display error message to admin  
                error.Text = "Mask type added to database. ";
                error.Visible = true;
            }
            //If size already exists
            else if (size.Equals("error"))
            {
                //Display error message to admin 
                error.Text = "size already exists. ";
                error.Visible = true;
            }
        }
    }
}