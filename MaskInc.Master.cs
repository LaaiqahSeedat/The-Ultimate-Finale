using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class MaskInc : System.Web.UI.MasterPage
    {
        GroupServiceClient sr = new GroupServiceClient();
        public static List<ShoppingCart> cartItems = new List<ShoppingCart>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //On home page, show the number of different items there are in the cart
            if (Session["LoggedInUserID"] != null)
            {
                int ID = Convert.ToInt32(Session["LoggedInUserID"]);
                var user = sr.GetUser(ID);

                if (user.Usertype.Equals("Admin"))
                {
                   
                }
                else if(user.Usertype.Equals("Client"))
                {
                    
                }
            }
            else
            {
               
            }

    }


        protected void submit_Logout(object sender, EventArgs e)
        {
            Session["LoggedInUserID"] = null;
            Response.Redirect("Login.aspx");
        }

    }
}