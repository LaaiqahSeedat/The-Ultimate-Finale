using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class EditPSize : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Button click gets details of existing Mask off ID 
        protected void EditPSize_Click(object sender, EventArgs e)
        {
            //Ask admin the P_Size they wish to edit 
            int P_Size = Convert.ToInt32(P_SizeID.Value);
            /*int sizeid = Convert.ToInt32(SizeID.Value);
            int psize = Convert.ToInt32(PSizeID.Value);*/

            //Get product based off ID 
            var PSize = SR.Getproductsize(1, 1);
            //If its NOT the initial visit to page
            if (!IsPostBack)
            {
                //SizeID.Value = PSize.
            }
        }

        //Button click edits details of exising Mask
        protected void UpdatePSize_Click(object sender, EventArgs e)
        {
            //Get the Mask id  
            /*int Mask_ID = Convert.ToInt32(MaskID.Value);
            //Conversion from String to Integer
            int admin = Convert.ToInt32(MaskAdmin.Value);

            string edit = SR.edittype(MaskName.Value, MaskDescription.Value, admin, Mask_ID);

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
            }*/
        }
    }
}