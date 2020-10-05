using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class InvoiceForClient : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the logged in user's id 
            int client_ID = 5/*Convert.ToInt32(Session["LoggedInUser"])*/;

            //If user is logged in 
            if (client_ID > 0)
            {
                //Get the client's invoice/s
                dynamic allInvoices = SR.GetInvoicebyclient(client_ID);
                //Get client's details 
                var user = SR.GetUser(client_ID);
                string displayInvoice = "";

                //Loop through all the invoices   
                foreach (Order_Table i in allInvoices)
                {
                    //Get one invoice based off id 
                    Order_Table invoice = SR.GetInvoice(i.Order_Id);

                    displayInvoice += "<tr><td class='name'>" + user.Name + "</td>";
                    displayInvoice += "<td class='date'>" + invoice.Order_date + "</td>";
                    displayInvoice += "<td class='quantity'>" + invoice.Order_Quantity + "</td>";
                    displayInvoice += "<td class='status'>" + invoice.Order_Status + "</td>";
                    displayInvoice += "<td class='total'>R" + Math.Round(invoice.Order_Total, 2) + "</td>";
                    displayInvoice += "<td class='see-more'><div class='seeMore-btn'><div class='row'><div class='col-lg-5 offset-lg-1 text-left text-lg-right'>";
                    displayInvoice += " <a href='Invoice.aspx'?ID=" + invoice.Order_Id + "class='site-btn update-btn'>See more</a></div></div></div></td></tr>";

                    invoice = null;
                }
                AllInvoiceID.InnerHtml = displayInvoice;
            }
            //If user is not logged in 
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}