<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="Cultural.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="product-page">
        <div class="container">
            <div class="product-control">
                <a href="Custom.aspx">Previous</a>
                <a href="CheckOut.aspx">Next</a>
            </div>
            </div>
        </section>
            
    <!-- Product Page Section End -->
     <!-- Catalogue will come in here -->
                <div id="cultural" runat="server">

             </div>
    <!-- Related Product Section Begin -->
    <section class="related-product spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <div class="section-title">
                        <h2>More products</h2>
                    </div>
                </div>
            </div>
            <div class="row">
            <div class="col-lg-3 col-sm-6 mix all dresses bags">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="assets/img/Cultural/IMG_1359.JPG" alt=""></a>
                            <div class="p-status sale">sale</div>
                        </figure>
                        <div class="product-text">
                            <h6>Diamond cross face mask</h6>
                            <p>R50/box</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all shoes accesories">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="assets/img/Cultural/pattern2.jpg" alt=""></a>
                            <div class="p-status">new</div>
                        </figure>
                        <div class="product-text">
                            <h6>Africa Print mask</h6>
                            <p>R150/box</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all shoes accesories">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="assets/img/Cultural/IMG_1360.JPG"alt=""></a>
                            <div class="p-status popular">popular</div>
                        </figure>
                        <div class="product-text">
                            <h6>Pearl mask </h6>
                            <p>R170/10masks</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all dresses shoes">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="assets/img/Cultural/pattern6.jpg" alt=""></a>
                            <div class="p-status">new</div>
                        </figure>
                        <div class="product-text">
                            <h6>Old blou masks</h6>
                            <p>R150</p>
                        </div>
                    </div>
                </div>
            </div>
         </div>
    </section>
    <!-- Related Product Section End -->
</asp:Content>
