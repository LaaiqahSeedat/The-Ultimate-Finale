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

            dynamic masks = sr.Getallproducts();
            string display = " ";
            int n = 0;
            display += "<div class='row'>";

            foreach (GroupServiceReference.Product p in masks)
            {
                if (n == 4)
                {
                    display += "</div><br/><div class='row'>";
                    n = 0;
                }
                display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                display += "<div class='block-4-text p-4'>";
                display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                display += "</div></div></div>";

                n++;
            }
            display += "</div>";
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
                products = sr.Getproductbyprice(0, 15);
                prices.Items.FindByValue("P1").Selected = true;

            }
            else if (query.Equals("P2"))
            {
                products = sr.Getproductbyprice(16, 30);
                prices.Items.FindByValue("P2").Selected = true;

            }
            else if (query.Equals("P3"))
            {
                products = sr.Getproductbyprice(31, 50);
                prices.Items.FindByValue("P3").Selected = true;


                cat.InnerHtml = display;
            }
            else if (query.Equals("P4"))
            {
                products = sr.Getproductbyprice(51, 10000);
                prices.Items.FindByValue("P5").Selected = true;
                cat.InnerHtml = display;
            }

            //-----------------DISPLAY BY SORTING------------//
            foreach (GroupServiceReference.Product p in masks)
            {
                if (n == 4)
                {
                    display += "</div><br/><div class='row'>";
                    n = 0;
                }
                display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                display += "<div class='block-4-text p-4'>";
                display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                // display += "<div class='col-md-3'>";
                // display += "<button class='btn btn-dark' title='Add To Cart' onClick='addtocart(" + p.Product_Id + ")'><i class='fa fa-shopping-cart'></i></button>";
                //display += "</div>";
                display += "</div></div></div>";

                n++;
            }
            display += "</div>";
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
                foreach (GroupServiceReference.Product p in masks)
                {
                    if (n == 4)
                    {
                        display += "</div><br/><div class='row'>";
                        n = 0;
                    }
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    // display += "<div class='col-md-3'>";
                    // display += "<button class='btn btn-dark' title='Add To Cart' onClick='addtocart(" + p.Product_Id + ")'><i class='fa fa-shopping-cart'></i></button>";
                    //display += "</div>";
                    display += "</div></div></div>";

                    n++;
                }
                display += "</div>";
                cat.InnerHtml = display;

                cat.InnerHtml = display;
            }
            else if (query.Equals("S2"))
            {
                products = sr.Getproductbysize(2);
                sizes.Items.FindByValue("S2").Selected = true;
                //-----------------DISPLAY BY SORTING------------//
                foreach (GroupServiceReference.Product p in masks)
                {
                    if (n == 4)
                    {
                        display += "</div><br/><div class='row'>";
                        n = 0;
                    }
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    // display += "<div class='col-md-3'>";
                    // display += "<button class='btn btn-dark' title='Add To Cart' onClick='addtocart(" + p.Product_Id + ")'><i class='fa fa-shopping-cart'></i></button>";
                    //display += "</div>";
                    display += "</div></div></div>";

                    n++;
                }
                display += "</div>";
                cat.InnerHtml = display;
            }
            else if (query.Equals("S3"))
            {
                products = sr.Getproductbysize(3);
                sizes.Items.FindByValue("S3").Selected = true;
                //-----------------DISPLAY BY SORTING------------//
                foreach (GroupServiceReference.Product p in masks)
                {
                    if (n == 4)
                    {
                        display += "</div><br/><div class='row'>";
                        n = 0;
                    }
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    // display += "<div class='col-md-3'>";
                    // display += "<button class='btn btn-dark' title='Add To Cart' onClick='addtocart(" + p.Product_Id + ")'><i class='fa fa-shopping-cart'></i></button>";
                    //display += "</div>";
                    display += "</div></div></div>";

                    n++;
                }
                display += "</div>";
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
                foreach (GroupServiceReference.Product p in masks)
                {
                    if (n == 4)
                    {
                        display += "</div><br/><div class='row'>";
                        n = 0;
                    }
                    display += "<div class='col-sm-6 col-lg-4 mb-4' data-aos='fade-up'>";
                    display += "<div class='block-4 text-center border'><figure class='block-4-image'>";
                    display += "<a href='AboutProduct.aspx?ID=" + p.Product_Id + "'><img src='" + p.Image + "'alt='" + p.Name + "'class=ímg-fluid'></a></figure>";
                    display += "<div class='block-4-text p-4'>";
                    display += "<h3><a href='AboutProduct.aspx/ID=" + p.Product_Id + "'>" + p.Name + "</a></h3><p class='mb-0>" + p.Description + "</p>";
                    display += "<p class='text-primary font-weight-bold'>R " + Math.Round(p.Unit_Price, 2) + "</p>";
                    // display += "<div class='col-md-3'>";
                    // display += "<button class='btn btn-dark' title='Add To Cart' onClick='addtocart(" + p.Product_Id + ")'><i class='fa fa-shopping-cart'></i></button>";
                    //display += "</div>";
                    display += "</div></div></div>";

                    n++;
                }
                display += "</div>";
                cat.InnerHtml = display;
            }
        }

    }
}