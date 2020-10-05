using Group_MaskInc_FrontEnd.GroupServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        GroupServiceClient sr = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Register_Click(object sender, EventArgs e)
        {
            if (Password.Value != ConfirmPass.Value)
            {
                error.Text = "Passwords do not match";
                error.Visible = true;
            }
            else
            {

                string registered = sr.Register(Username.Value, Hash.HashPassword(Password.Value), Name.Value, Email.Value, Contact.Value, 1, Address.Value, "yes", Surname.Value, "Client");
                if (registered == "registered")
                {
                    Response.Redirect("Login.aspx");
                }
                else if (registered == "unsuccessful")
                {
                    error.Text = "Something went wrong, please try again later";
                    error.Visible = true;
                }
                else if (registered == "unsuccessful")
                {
                    error.Text = "The user already exists";
                }
            }


        }
    }
}