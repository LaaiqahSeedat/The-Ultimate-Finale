using Group_MaskInc_FrontEnd.GroupServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        GroupServiceClient SR = new GroupServiceClient();
        protected User_Table user;
        protected decimal total;
        protected int quant;
        protected decimal absTot;
        protected decimal shipping;
        protected decimal discount;
        protected Delivery[] deliveries;
        protected int clientId;
        protected void Page_Load(object sender, EventArgs e)
        {
            int client_id = 7;
            clientId = client_id;
            deliveries = SR.GetAllDeliveries();
            user = SR.GetUser(SR.GetClient(client_id).User_Id);
            quant = SR.CalculateTotalQuantity(client_id);
            total = SR.CalculateTotalPrice(client_id);
            shipping = quant >= 10000 ? 0 : Math.Round(total * (decimal)0.02, 2);
            discount = quant > 5000 ? Math.Round(total * (decimal)0.05) : 0;
            absTot = total + shipping - discount;
        }
    }
}