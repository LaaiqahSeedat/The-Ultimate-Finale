using Group_MaskInc_FrontEnd.GroupServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm9 : System.Web.UI.Page
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
                    //removeproduct.Visible = false;
                }
                else if (user.Usertype.Equals("admin"))
                {
                    //addtocart.Visible = false;
                }
            }
            // dynamic categories = sr.GetallMasktypes();
            dynamic products = sr.GetProductsByMask_Type("Custom");
            string display = " ";



            // if (categories.Mask_Id == products.Mask_Id && categories.Name.Equals("Custom"))
            //{

            foreach (GroupServiceReference.Product p in products)
            {
                display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                display += "<div class='block-4-text p-4'>";
                display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                display += "</div></div></div>";
            }
            custom.InnerHtml = display;

            // }

        }
        protected void submit_addtocart(object sender, EventArgs e)
        {

        }

        protected void submit_removeproduct(object sender, EventArgs e)
        {

        }
        protected void submit_addcustom(object sender, EventArgs e)
        {
            Response.Redirect("AddCustomProduct.aspx");
        }
    }
}