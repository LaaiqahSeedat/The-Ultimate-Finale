using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class Product : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //Button click adds new products to database 
        protected void AddProduct_Click(object sender, EventArgs e)
        {
            //Conversion from String to Integer 
            int price = Convert.ToInt32(ProPrice.Value);
            int quantity = Convert.ToInt32(ProQuantity.Value);

            int admin = 0;
            int maskID = 0;
            int active = 0;

            //If product is active, change it to 1
            if (ProActive.Value.Equals("1"))
            {
                active = 1;
            }
            else
            {
                active = 0;
            }

            //Getting product category 
            if (ProCategory.Value.Equals("1"))
            {
                maskID = 1;
            }
            else if (ProCategory.Value.Equals("2"))
            {
                maskID = 2;
            }
            else if (ProCategory.Value.Equals("3"))
            {
                maskID = 3;
            }
            else if (ProCategory.Value.Equals("4"))
            {
                maskID = 4;
            }

            admin = Convert.ToInt32(Session["LoggedInUser"]);

            //Service function to add products to database 
            string add = SR.Addproducts(ProName.Value, ProDescription.Value, price, active, maskID, admin, quantity);

            //if adding is successful
            if (add.Equals("added"))
            {
                //redirect to the home page 
                Response.Redirect("Home.aspx");
            }
            //If product was not added to database 
            else if (add.Equals("not added"))
            {
                //Display error message to admin  
                error.Value = "Product added to database. ";
                error.Visible = true;
            }
            //If product already exists
            else if (add.Equals("error"))
            {
                //Display error message to admin 
                error.Value = "Product already exists. ";
                error.Visible = true;
            }
        }
    }
}