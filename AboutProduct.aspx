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
   <div class="mt-10">
    <asp:Button ID="btn_cart" runat="server" Text="Add to Cart" class="genric-btn primary-border" OnClick="AddToCart_Click" />
    </div>
    <div class="mt-10">
    <asp:Button ID="btn_remove" runat="server" Text="Remove Product" class="genric-btn primary-border" OnClick="RemoveProduct_Click" />
    </div>
        </div>                      
    </section>

     <section class="information">
         <!-- product information will come in here -->
                <div id="prod" runat="server">

             </div>
    </section>
</asp:Content>
