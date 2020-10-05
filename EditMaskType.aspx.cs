using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class EditMaskType : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button click gets details of existing Mask off ID 
        protected void EditMaskType_Click(object sender, EventArgs e)
        {
            //Ask admin the Mask they wish to edit 
            int Mask_ID = Convert.ToInt32(MaskID.Value);
            //Get product based off ID 
            var Mask = SR.GetMask(Mask_ID);
            //If its NOT the initial visit to page
            if (!IsPostBack)
            {
                //Display Mask info to admin 
                MaskName.Value = Mask.Name;
                MaskDescription.Value = Mask.Description;
                MaskAdmin.Value = Convert.ToString(Mask.Admin_User_Id);
            }
        }

        //Button click edits details of exising Mask
        protected void UpdateMaskType_Click(object sender, EventArgs e)
        {
            //Get the Mask id  
            int Mask_ID = Convert.ToInt32(MaskID.Value);
            //Conversion from String to Integer
            int admin = Convert.ToInt32(MaskAdmin.Value);

            string edit = SR.Edittype(MaskName.Value, MaskDescription.Value, admin, Mask_ID);

            //if edit is successful
            if (edit.Equals("updated"))
            {
                Response.Redirect("Home.aspx");
            }
            //if edit is unsuccessful
            else if (edit.Equals("unsuccessful update"))
            {
                error.Text = "Mask edit changes not saved. ";
                error.Visible = true;
            }
            //if product doesn't exist. 
            else if (edit.Equals("Mask does not exist"))
            {
                error.Text = "Mask doesn't exist.";
                error.Visible = true;
            }
        }
    }
}