using Group_MaskInc_FrontEnd.GroupServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        GroupServiceClient sr = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Session["LoggedInUserID"]);
            var user = sr.GetUser(ID);
            if (Session["LoggedInUserID"] != null)
            {
                if (user.Usertype.Equals("client"))
                {
                    btn_remove.Visible = false;
                }
                else if (user.Usertype.Equals("admin"))
                {
                    btn_cart.Visible = false;
                }
            }

            var itemid = Request.QueryString["ID"];
            var mask = sr.GetProduct(Convert.ToInt32(itemid));

            string displayi = " ";
            string display = " ";

            displayi += "<center><img src='" + mask.Image + "' alt='" + mask.Name + "' class='img-fluid'></center>";
            display += "<center><h1>" + mask.Name + "</h1><p>" + mask.Description + "</p><p> R" + Math.Round(mask.Unit_Price, 2) + "</p></center>";
            pimage.InnerHtml = displayi;
            prod.InnerHtml = display;

        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            //getting the user ifm
            int ID = Convert.ToInt32(Session["LoggedInUserID"]);

            //getting the product id
            var itemid = Request.QueryString["ID"];
            var id = Convert.ToInt32(itemid);
            var mask = sr.GetProduct(Convert.ToInt32(itemid));

            //adding to cart
            bool add = sr.AddtoCart(id, mask.Product_Id,50,mask.Unit_Price);
        }

        protected void RemoveProduct_Click(object sender, EventArgs e)
        {
            //getting the user ifm
            int ID = Convert.ToInt32(Session["LoggedInUserID"]);

            //getting the product
            var itemid = Request.QueryString["ID"];
            Response.Redirect("RemoveProduct.aspx?ID=" + itemid);
        }
    }
}