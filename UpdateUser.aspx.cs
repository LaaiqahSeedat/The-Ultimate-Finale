using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        GroupServiceClient sr = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInUserID"] != null)
            {
                int ID = Convert.ToInt32(Session["LoggedInUserID"]);
                var user = sr.GetUser(ID);

                if (!IsPostBack)
                {
                    Username.Value = user.Username;
                    Name.Value = user.Name;
                    Email.Value = user.Email;
                    Contact.Value = user.Contact_Number;
                    Address.Value = user.Address;

                    if (user.Usertype.Equals("client"))
                    {
                        var c = sr.GetClient(ID);
                        BusinessT.Value = c.Business_Type;
                    }
                    else if (user.Usertype.Equals("admin"))
                    {
                        var a = sr.GetAdmin(ID);
                        BusinessT.Value = a.Surname;
                    }
                    else
                    {
                        error.Text = "User not found";
                    }


                }

            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Session["LoggedInUserID"]);
            var user = sr.GetUser(ID);
            string update = " ";
            string pass = " ";

            if (user.Usertype.Equals("admin"))
            {

                update = sr.UpdateInfo(Username.Value, Name.Value, Email.Value, Contact.Value, Address.Value, ID, BusinessT.Value, "yes");
                pass = sr.Changepassword(user.Email, ID, Hash.HashPassword(Password.Value));
            }
            else if (user.Usertype.Equals("client"))
            {

                update = sr.UpdateInfo(Username.Value, Name.Value, Email.Value, Contact.Value, Address.Value, ID, "yes", BusinessT.Value);
                pass = sr.Changepassword(user.Email, ID, Hash.HashPassword(Password.Value));
            }
            else
            {
                error.Text = "Something went wrong, please try again";
            }

            if (update == "updated")
            {
                Response.Redirect("Home.aspx");
            }
            else if (update == "unregistered")
            {
                error.Text = "Please Register";
                error.Visible = true;
            }
            else if (update == "unsuccessful updated")
            {
                error.Text = "This email exists";
                error.Visible = true;
            }
            else
            {
                error.Text = "Something went wrong please try agan later";
                error.Visible = true;
            }
        }
    }
}