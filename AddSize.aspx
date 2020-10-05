<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="AddSize.aspx.cs" Inherits="Group_MaskInc_FrontEnd.AddSize" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="whole-wrap">
        <div class="container box_1170">

            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Edit Size</h3>

                         <div class="mt-10">
                            <input type="text" name="Name" placeholder="Name"
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Name'" required
                                class="single-input" runat="server" id="Name">
                        </div>

                         <div class="mt-10">
                            <input type="text" name="Dimension" placeholder="Dimension"
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Dimension'" required
                                class="single-input" runat="server" id="Dimension">
                        </div>

                        <div class="mt-10">
                            <asp:Button ID="btn_AddSize" runat="server" Text="Add Size" class="genric-btn primary-border" OnClick="AddSize_Click" />
                        </div>

                        <div class="mt-10">
                            <asp:Button ID="btn_EditSize" runat="server" Text="Edit Size" class="genric-btn primary-border" OnClick="EditSize_Click" />
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
