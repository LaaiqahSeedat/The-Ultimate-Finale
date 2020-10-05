using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class Payment : System.Web.UI.Page
    {
        GroupServiceClient SR = new GroupServiceClient();
        protected string clientId;
        protected string shipping;
        protected string addr;
        protected PaymentType[] types;

        protected void Page_Load(object sender, EventArgs e)
        {
            types = SR.getPaymentTypes();
            clientId = Request["clientId"];
            shipping = Request["shipping"];
            addr = Request["address"];

            if (Request["cardNum"] != null)
            {

                int paymentId = SR.makePayment(Request["cardNum"], Request["cvv"], Request["expiry"], Request["holder"], Request["type"]);
                SR.placeOrder(int.Parse(Request["clientId"]), int.Parse(Request["clientId"]), paymentId);
                Response.Redirect("thankyou.aspx");

            }
        }
    }
}