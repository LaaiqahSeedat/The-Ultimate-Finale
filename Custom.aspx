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
    <div class="mt-10">
    <asp:Button ID="btn_custom" runat="server" Text="Create Custom" class="genric-btn primary-border" OnClick="AddCustom_Click" />
    </div>
</asp:Content>
