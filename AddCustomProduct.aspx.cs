using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class AddCustomProduct : System.Web.UI.Page
    {

        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button click adds new custom products to database 
        protected void AddCustomProduct_Click(object sender, EventArgs e)
        {
            int filter;
            //If product requires filter, change it to 1
            if (Filter_Option.Value.Equals("1"))
            {
                filter = 1;
            }
            //Product doesn't require filter 
            else
            {
                filter = 0;
            }

            string Cus_size = size.Value;
            string Cus_colour = colour.Value;
            string imageURL = Upload_Logo.Value;

            //Add custom product details to db using service function 
            string add_CustomPro = SR.Addcustom(filter, Cus_size, Cus_colour, imageURL);

            //Custom product successfully created 
            if (add_CustomPro.Equals("added"))
            {
                Response.Redirect("Home.aspx");
            }
            //Custom product unsuccessful
            else
            {
                error.Value = "Custom product not saved. Please try again. ";
                error.Visible = true;
            }
        }
    }
}