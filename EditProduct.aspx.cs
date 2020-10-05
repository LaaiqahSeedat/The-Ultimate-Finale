using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class EditProduct : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();

        //Page load gets details of existing product off ID 

        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the product id using URL parameter
            String param = Request.QueryString["ID"];
            int product_ID = Convert.ToInt32(param);

            //If a product is selected 
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

        //Button click changes/updates product details
        protected void EditProduct_Click(object sender, EventArgs e)
        {
            //Get the product id using URL parameter
            String param = Request.QueryString["ID"];
            int product_ID = Convert.ToInt32(param);

            //If ID is not null
            if (product_ID > 0)
            {
                //Conversion from String to Integer 
                int price = Convert.ToInt32(ProPrice.Value);
                int maskID = Convert.ToInt32(ProCategory.Value);
                int quantity = Convert.ToInt32(ProQuantity.Value);

                //Get the current admin logged in
                int admin = Convert.ToInt32(Session["LoggedInUser"]);

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

                string edit = SR.Editproduct(ProName.Value, ProDescription.Value, price, product_ID, active, maskID, admin, quantity);

                //if edit is successful
                if (edit.Equals("updated"))
                {
                    Response.Redirect("Home.aspx");
                }
                //if edit is unsuccessful
                else if (edit.Equals("unsuccessful update"))
                {
                    error.Value = "Product edit changes not saved. ";
                    error.Visible = true;
                }
                //if product doesn't exist. 
                else if (edit.Equals("product does not exist"))
                {
                    error.Value = "Product doesn't exist.";
                    error.Visible = true;
                }
            }
            else
            {
                Response.Redirect("AboutProduct.aspx");
            }
        }
    }
}