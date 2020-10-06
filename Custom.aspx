<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="Custom.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="product-page">
        <div class="container">
            <div class="product-control">
                <a href="Nano Range.aspx">Previous</a>
                <a href="CheckOut.aspx">Next</a>
            </div>
            
        </div>
    </section>
    <!-- Product Page Section End -->
      <!-- Catalogue will come in here -->
                <div id="custom" runat="server">

             </div>
    <!-- Related Product Section Begin -->
    <section class="related-product spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <div class="section-title">
                        <h2>Related Products</h2>
                    </div>
                </div>
            </div>
            <div class="col-lg-3 col-sm-6 mix all dresses bags">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="img/products/images (6).jpg" alt=""></a>
                            <div class="p-status sale">sale</div>
                        </figure>
                        <div class="product-text">
                            <h6>Plain Masks</h6>
                            <p>R50/box</p>
                        </div>
                    </div>
                </div>
              <div class="row">
                <div class="col-lg-3 col-sm-6 mix all shoes accesories">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="img/products/images (19).jpg" alt=""></a>
                            <div class="p-status">new</div>
                        </figure>
                        <div class="product-text">
                            <h6>Kids Disney Masks</h6>
                            <p>R150/box</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all shoes accesories">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="img/products/images (24).jpg" alt=""></a>
                            <div class="p-status popular">popular</div>
                        </figure>
                        <div class="product-text">
                            <h6>Nano Range Formal black </h6>
                            <p>R170/10masks</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all dresses shoes">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx#"><img src="img/products/images (28).jpg" alt=""></a>
                            <div class="p-status">new</div>
                        </figure>
                        <div class="product-text">
                            <h6>Wedding sets</h6>
                            <p>R150</p>
                        </div>
                    </div>
                </div>
             </div>
        </div>
    </section>
    <!-- Related Product Section End -->
</asp:Content>
