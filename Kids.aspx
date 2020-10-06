<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="Kids.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="product-page">
        <div class="container">
            <div class="product-control">
                <a href="Cultural.aspx">Previous</a>
                <a href="CheckOut.aspx">Next</a>
            </div>
           
        </div>
    </section>
    <!-- Product Page Section End -->
     <!-- Catalogue will come in here -->
                <div id="kids" runat="server">

             </div>
    <!-- Related Product Section Begin -->
    <section class="related-product spad">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <div class="section-title">
                        <h2>More Products</h2>
                    </div>
                </div>
            </div>
           <div class="row">
          <div class="col-lg-3 col-sm-6 mix all dresses bags">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="assets/img/Kids/images (32).jpg" alt=""></a>
                            <div class="p-status sale">sale</div>
                        </figure>
                        <div class="product-text">
                            <h6>Hello kitty masks</h6>
                            <p>R50/box</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all shoes accesories">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="assets/img/Kids/images (18).jpg" alt=""></a>
                            <div class="p-status">new</div>
                        </figure>
                        <div class="product-text">
                            <h6>Kids Blue Disney Masks</h6>
                            <p>R150/box</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all shoes accesories">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx"><img src="assets/img/Kids/U16624135-2-M.jpg"alt=""></a>
                            <div class="p-status popular">popular</div>
                        </figure>
                        <div class="product-text">
                            <h6>love message masks </h6>
                            <p>R170/10masks</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-sm-6 mix all dresses shoes">
                    <div class="single-product-item">
                        <figure>
                            <a href="CheckOut.aspx#"><img src="assets/img/Kids/images (17).jpg" alt=""></a>
                            <div class="p-status">new</div>
                        </figure>
                        <div class="product-text">
                            <h6>Kids Black Disney Masks</h6>
                            <p>R150/box</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Related Product Section End -->
</asp:Content>
