using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class RemoveProduct : System.Web.UI.Page
    {
        //Service reference to use service functions
        GroupServiceClient SR = new GroupServiceClient();

        //Page load gets details of existing product off ID 
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the product id using URL parameter
            String param = Request.QueryString["ID"];
            int product_ID = Convert.ToInt32(param);

            // If a product has been selected 
            if (product_ID > 0)
            {
                //Get product based off ID 
                var product = SR.GetProduct(product_ID);
                //If its NOT the initial visit to page
                if (!IsPostBack)
                {
                    //Display product info to admin 
                    ProName.Value = product.Name;
                    ProDescription.Value = product.Description;
                    ProPrice.Value = Convert.ToString(product.Unit_Price);
                    ProActive.Value = Convert.ToString(product.Active);
                    ProCategory.Value = Convert.ToString(product.Mask_Id);
                    ProQuantity.Value = Convert.ToString(product.Product_Quantity);
                }
            }
            else
            {
                Response.Redirect("AboutProduct.aspx");
            }
        }

        //Button click gets product to remove from database based off ID
        //Button click sets product active attribute to 0
        protected void RemoveProduct_Click(object sender, EventArgs e)
        {
            //Get the product id using URL parameter
            String param = Request.QueryString["ID"];
            int product_ID = Convert.ToInt32(param);

            //Service function to set product active attribute 0
            string delete = SR.DeleteProduct(product_ID);

            //if deleting is successfull
            if (delete.Equals("Deleted"))
            {
                //Redirect to home page 
                Response.Redirect("Home.aspx");
            }
            else if (delete.Equals("Product not deleted"))
            {
                error.Value = "Product couldn't be deleted. Please try again.";
                error.Visible = true;
            }
            else if (delete.Equals("Product doesn't exist"))
            {
                error.Value = "Product does not exist.";
                error.Visible = true;
            }
        }
    }
}