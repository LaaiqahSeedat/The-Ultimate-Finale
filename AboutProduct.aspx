<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="AboutProduct.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1><i class="fa fa-cart-plus"></i>&nbsp;About Product</h1>
    <hr />
    <section class="product-page">
        <div class="container">
            <div class="product-control">
                <a href="Catalog.aspx">Previous</a>
                <a href="CheckOut.aspx">Next</a>
            </div>
            <!-- Image will appear in here -->
                <div id="pimage" runat="server">

             </div>
    <div class="row">
            <div class="col-md-6">
                <button class="btn btn-dark"  onclick="addtocart()"><i class="fa fa-shopping-cart"></i>&nbsp;Add To Cart</button>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <button class="btn btn-dark"  onclick="removeproduct()"><i class="fa fa-product-management"></i>&nbsp;Remove Product</button>
            </div>
        </div> 
        </div>                      
    </section>

     <section class="information">
         <!-- product information will come in here -->
                <div id="prod" runat="server">

             </div>
    </section>
</asp:Content>
