<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="EditPSize.aspx.cs" Inherits="Group_MaskInc_FrontEnd.EditPSize" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="whole-wrap">
        <div class="container box_1170">

            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Add Product Size</h3>

                        <div class="mt-10">
                            <input type="number" name="PSize_ID" placeholder="Product Size ID" min="1" 
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Product Size ID'" required
                                class="single-input" runat="server" id="P_SizeID">
                        </div>

                        <div class="mt-10">
                            <asp:Button ID="EditP_Size" runat="server" Text="Edit Product Size" class="genric-btn primary-border" OnClick="EditPSize_Click" />
                        </div>

                         <div class="mt-10">
                            <input type="number" name="Size_ID" placeholder="Size ID" min ="1"
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Size ID'" required
                                class="single-input" runat="server" id="Size_ID">
                        </div>

                         <div class="mt-10">
                            <input type="number" name="Product_Size" placeholder="Product Size"
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Product Size'" required
                                class="single-input" runat="server" id="P_Size">
                        </div>

                        <div class="mt-10">
                            <asp:Button ID="btn_UpdatePSize" runat="server" Text="Update Product Size" class="genric-btn primary-border" OnClick="UpdatePSize_Click" />
                        </div>

                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="" visible="false" ></asp:Label>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
