using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class EditCustomProduct : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();

        //Page load gets details of existing custom product off Client_ID
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get logged in client ID 
            int client_ID = Convert.ToInt32(Session["LoggedInUser"]);

            //If user is logged in 
            if (client_ID > 0)
            {
                //Get custom product 
                var cus_Product = SR.Getcustom(client_ID);

                //If its NOT the initial visit to page
                if (!IsPostBack)
                {
                    //Display custom product info to user 
                    Filter_Option.Value = Convert.ToString(cus_Product.Filter);
                    size.Value = cus_Product.Custom_Size;
                    colour.Value = cus_Product.Colour;
                    Upload_Logo.Value = cus_Product.Logo;
                }
            }
            //If user is not logged in 
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        //Button click changes/updates custom product details
        protected void EditCustomProduct_Click(object sender, EventArgs e)
        {
            //Get logged in client ID 
            int client_ID = Convert.ToInt32(Session["LoggedInUser"]);

            //If user is logged in 
            if (client_ID > 0)
            {
                int filter = 0;
                if (Filter_Option.Value.Equals("Yes"))
                {
                    filter = 1;
                }
                else
                {
                    filter = 0;
                }

                string _size = size.Value;
                string _colour = colour.Value;
                string imageURL = Upload_Logo.Value;

                //Edit info using service function 
                string cus_Product = SR.Editcustom(filter, _size, _colour, client_ID, imageURL);
              

                //if edit is successful
                if (cus_Product.Equals("updated"))
                {
                    Response.Redirect("Home.aspx");
                }
                //if edit is unsuccessful
                else if (cus_Product.Equals("unsuccessful update"))
                {
                    error.Value = "Product edit changes not saved. ";
                    error.Visible = true;
                }
                //if product doesn't exist. 
                else if (cus_Product.Equals("custom product does not exist"))
                {
                    error.Value = "Custom product doesn't exist.";
                    error.Visible = true;
                }
            }
            //User is not logged in 
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}