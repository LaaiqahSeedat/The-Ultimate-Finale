using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        GroupServiceClient sr = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login_Click(object sender, EventArgs e)
        {
            int Id = sr.Login(Email.Value, Password.Value);
            var user = sr.GetUser(Id);
            if (Id == 0)
            {
                error.Visible = true;
            }
            else
            {
                Session["LoggedInUserID"] = Id;
                Response.Redirect("Home.aspx");

            }

        }
    }
}