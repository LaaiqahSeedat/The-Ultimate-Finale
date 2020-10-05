using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class InvoiceByDate : System.Web.UI.Page
    {
        //Service reference to use service functions 
        GroupServiceClient SR = new GroupServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GetInvoice_Click(object sender, EventArgs e)
        {
            //convert string to date 
            DateTime dt = Convert.ToDateTime(clientInvoice_date.Value);

            //Use service function to get invoice based off date 
            dynamic invoices = SR.GetInvoicebbydate(dt);

            if (invoices != null)
            {
                string order_date = "";
                string order_total = "";
                string order_status = "";
                string order_tax = "";
                string order_shipping = "";
                string order_discount = "";
                string order_quantity = "";
                //string delivery_name = "";

                //Get most recent order's details 
                foreach (Order_Table i in invoices)
                {
                    order_date = Convert.ToString(i.Order_date);
                    order_total = Convert.ToString(i.Order_Total);
                    order_status = Convert.ToString(i.Order_Status);
                    order_tax = Convert.ToString(i.Order_Tax);
                    order_shipping = Convert.ToString(i.Order_Shipping);
                    order_discount = Convert.ToString(i.Order_Discount);
                    order_quantity = Convert.ToString(i.Order_Quantity);
                    //delivery_name = delivery.Name;

                    //Display info for to client.
                    clientOrder_date.Value = order_date;
                    clientOrder_Status.Value = order_status;
                    clientOrder_Total.Value = order_total;
                    clientOrder_Tax.Value = order_tax;
                    clientOrder_Discount.Value = order_discount;
                    clientOrder_Shipping.Value = order_shipping;
                    clientOrder_Quantity.Value = order_quantity;
                    //clientOrder_Delivery.Value = delivery_name;
                }
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void GoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}