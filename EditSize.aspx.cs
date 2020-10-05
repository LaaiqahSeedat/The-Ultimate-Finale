using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class EditSize : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button click gets details of existing Size off ID 
        protected void EditSize_Click(object sender, EventArgs e)
        {
            //Ask admin the size they wish to edit 
            int Size_ID = Convert.ToInt32(SizeID.Value);
            //Get size based off ID 
            var Size = SR.Getsize(Size_ID);
            //If its NOT the initial visit to page
            if (!IsPostBack)
            {
                //Display size info to admin 
                Name.Value = Size.Name;
                Dimension.Value = Size.Dimensions;
                SizeID.Value = Convert.ToString(Size.Size_Id);
            }
        }

        //Button click edits details of exising size 
        protected void UpdateSize_Click(object sender, EventArgs e)
        {
            //Get the size id  
            int Size_ID = Convert.ToInt32(SizeID.Value);

            string edit = SR.Editsize(Name.Value, Dimension.Value, Size_ID);

            //if edit is successful
            if (edit.Equals("updated"))
            {
                Response.Redirect("Home.aspx");
            }
            //if edit is unsuccessful
            else if (edit.Equals("unsuccessful update"))
            {
                error.Text = "Size edit changes not saved. ";
                error.Visible = true;
            }
            //if size doesn't exist. 
            else if (edit.Equals("size does not exist"))
            {
                error.Text = "Size doesn't exist.";
                error.Visible = true;
            }
        }
    }
}