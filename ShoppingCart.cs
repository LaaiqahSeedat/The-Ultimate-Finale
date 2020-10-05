using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group_MaskInc_FrontEnd
{
    //Class that stores items in the shopping cart
    public class ShoppingCart
    {
        public int id;
        public int quantity;

        public ShoppingCart(int id_, int quantity_)
        {
            id = id_;
            quantity = quantity_;
        }
    }
}