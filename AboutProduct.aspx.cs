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
            if (Session["User"] != null)
            {

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

        protected void submit_addtocart(object sender, EventArgs e)
        {

        }

        protected void submit_removeproduct(object sender, EventArgs e)
        {

        }
    }
}