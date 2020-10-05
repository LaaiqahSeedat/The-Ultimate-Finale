using Group_MaskInc_FrontEnd.GroupServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm17 : System.Web.UI.Page
    {

        GroupServiceClient sr = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register(object sender, EventArgs e)
        {

            string admin = sr.AddAdmin(sr.GetUser(Convert.ToInt32(UserId.Value)), Surname.Value);
            if (admin == "added")
            {
                Response.Redirect("Login.aspx");
            }
            else if (admin == "Something went wrong try again")
            {
                error.Text = "Something went wrong, please try again later";
                error.Visible = true;
            }
            else if (admin == "unsuccessful")
            {
                error.Text = "The admin already exists";
            }
        }

    }
}