using Group_MaskInc_FrontEnd.GroupServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_MaskInc_FrontEnd
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        GroupServiceClient sr = new GroupServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Session["LoggedInUserID"]);
            var user = sr.GetUser(ID);
            if (Session["LoggedInUserID"] != null)
            {
                if (user.Usertype.Equals("client"))
                {
                    //removeproduct.Visible = false;
                }
                else if (user.Usertype.Equals("admin"))
                {
                    //addtocart.Visible = false;
                }
            }

            dynamic masks = sr.Getallproducts();
            string display = " ";

            foreach (GroupServiceReference.Product p in masks)
            {
                display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                display += "<div class='block-4-text p-4'>";
                display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                display += "</div></div></div>";
            }
            cat.InnerHtml = display;

            //-------------------------Getting by price----------------------//
            var query = "";
            dynamic products = null;

            if (Request.QueryString["Group"] != null)
            {
                query = Request.QueryString["Group"];
            }

            prices.Items.FindByValue("P1").Selected = false;
            prices.Items.FindByValue("P2").Selected = false;
            prices.Items.FindByValue("P3").Selected = false;
            prices.Items.FindByValue("P4").Selected = false;
            prices.Items.FindByValue("P5").Selected = false;
            query = "P3";
            if (query.Equals("P1"))
            {
                products = sr.Getproductbyprice(0, 25);
                prices.Items.FindByValue("P1").Selected = true;

            }
            else if (query.Equals("P2"))
            {
                products = sr.Getproductbyprice(26, 50);
                prices.Items.FindByValue("P2").Selected = true;

            }
            else if (query.Equals("P3"))
            {
                products = sr.Getproductbyprice(51, 150);
                prices.Items.FindByValue("P3").Selected = true;


                cat.InnerHtml = display;
            }
            else if (query.Equals("P4"))
            {

                cat.InnerHtml = display;
            }
            else if (query.Equals("P5"))
            {
                products = sr.Getproductbyprice(1001, 10000);
                prices.Items.FindByValue("P5").Selected = true;

            }

            //-----------------DISPLAY BY SORTING------------//
            foreach (GroupServiceReference.Product p in products)
            {
                display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                display += "<div class='block-4-text p-4'>";
                display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                display += "</div></div></div>";
            }

            cat.InnerHtml = display;

            //--------------------------Getting by size-----------------------//
            sizes.Items.FindByValue("S1").Selected = false;
            sizes.Items.FindByValue("S2").Selected = false;
            sizes.Items.FindByValue("S3").Selected = false;
            sizes.Items.FindByValue("S4").Selected = false;
            sizes.Items.FindByValue("S5").Selected = false;

            if (query.Equals("S1"))
            {
                products = sr.Getproductbysize(1);
                sizes.Items.FindByValue("S1").Selected = true;
                //-----------------DISPLAY BY SORTING------------//
                foreach (GroupServiceReference.Product p in products)
                {
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    display += "</div></div></div>";
                }

                cat.InnerHtml = display;
            }
            else if (query.Equals("S2"))
            {
                products = sr.Getproductbysize(2);
                sizes.Items.FindByValue("S2").Selected = true;
                //-----------------DISPLAY BY SORTING------------//
                foreach (GroupServiceReference.Product p in products)
                {
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    display += "</div></div></div>";
                }

                cat.InnerHtml = display;
            }
            else if (query.Equals("S3"))
            {
                products = sr.Getproductbysize(3);
                sizes.Items.FindByValue("S3").Selected = true;
                //-----------------DISPLAY BY SORTING------------//
                foreach (GroupServiceReference.Product p in products)
                {
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    display += "</div></div></div>";
                }

                cat.InnerHtml = display;
            }
            else if (query.Equals("S4"))
            {
                products = sr.Getproductbysize(4);
                sizes.Items.FindByValue("S4").Selected = true;
            }
            else if (query.Equals("S5"))
            {
                products = sr.Getproductbysize(5);
                sizes.Items.FindByValue("S5").Selected = true;
                //-----------------DISPLAY BY SORTING------------//
                foreach (GroupServiceReference.Product p in products)
                {
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    display += "</div></div></div>";
                }

                cat.InnerHtml = display;
            }
        }


        protected void submit_addtocart(object sender, EventArgs e)
        {

        }

        protected void submit_removeproduct(object sender, EventArgs e)
        {

        }
    }
}