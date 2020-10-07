using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Group_MaskInc_FrontEnd.GroupServiceReference;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        int ClientId = 9;
        GroupServiceClient SR = new GroupServiceClient();
        protected Group_MaskInc_FrontEnd.GroupServiceReference.Product[] products = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            remOrUpdate();

            //Client_ID Should be fetched for client
            products = SR.GetAllProductsInCart(ClientId);

            int Quantity = SR.CalculateTotalQuantity(ClientId);
            Decimal Total;
            Decimal TotalTaxIncl = SR.CalculateTotalPrice(ClientId);
            Decimal Discount = 0;
            if (Quantity > 5000)
            {
                //Include the 5% Discount
                Discount = (TotalTaxIncl * 5 / 100);
            }

            Total = (TotalTaxIncl * 100 / 115);
            Decimal Tax = (TotalTaxIncl * 15 / 115);
            Decimal Shipping;
            if (Quantity > 10000)
            {
                //Include Free shipping
                Shipping = 0;
            }
            else
            {

                Shipping = (TotalTaxIncl * 2 / 100);
            }
            Decimal TotalCart = Total + Tax + Shipping - Discount;
            String SummaryDisplay = " ";
            SummaryDisplay += " <tr><td class='total'>R" + Math.Round(Total, 2) + "</td><td class='tax'>R" + Math.Round(Tax, 2) + "</td><td class='shipping'>R" + Math.Round(Shipping, 2) + "</td><td class='Discount'> -R" + Math.Round(Discount, 2) + "</td><td class='total-cart-p'>R" + Math.Round(TotalCart, 2) + "</td></tr>";
            Summaries.InnerHtml = SummaryDisplay;

            String checkoutPage = " ";
            checkoutPage = "<a href='CheckOut.aspx' class='primary-btn'>Proceed to Checkout</a>";

            Checkout.InnerHtml = checkoutPage;

        }



        protected Group_MaskInc_FrontEnd.GroupServiceReference.Cart getCart(int pId)
        {
            return SR.GetCartItem(ClientId, pId);
        }

        private void remOrUpdate()
        {
            if (Request["rem"] != null)
            {
                SR.RemoveFromCart(ClientId, int.Parse(Request["rem"]));
                Response.Redirect("ShoppingCart.aspx");
            }
            else if (Request["clear"] != null)
            {
                SR.ClearTheCart(ClientId);
                Response.Redirect("ShoppingCart.aspx");
            }
            else if (Request["prodId"] != null)
            {
                SR.EditFromCart(
                    ClientId,
                    int.Parse(Request["prodId"]),
                    int.Parse(Request["quantity"]),
                    SR.GetProduct(int.Parse(Request["prodId"])).Unit_Price * int.Parse(Request["quantity"])
                );
                Response.Redirect("ShoppingCart.aspx");

            }
        }
    }
}