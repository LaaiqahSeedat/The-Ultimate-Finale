<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="EditMaskType.aspx.cs" Inherits="Group_MaskInc_FrontEnd.EditMaskType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="whole-wrap">
        <div class="container box_1170">

            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Edit Mask Type</h3>

                        <div class="mt-10">
                            <input type="number" name="Mask_ID" placeholder="Mask ID" min="1" 
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Mask ID'" required
                                class="single-input" runat="server" id="MaskID">
                        </div>

                        <div class="mt-10">
                            <asp:Button ID="btn_EditMaskType" runat="server" Text="Edit Mask Type" class="genric-btn primary-border" OnClick="EditMaskType_Click" />
                        </div>

                        <div class="mt-10">
                            <input type="text" name="Mask_Name" placeholder="Mask name"
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Mask name'" required
                                class="single-input" runat="server" id="MaskName">
                        </div>

                        <div class="mt-10">
                            <input type="text" name="Mask_Description" placeholder="Mask Description"
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Mask Description'" required
                                class="single-input" runat="server" id="MaskDescription">
                        </div>

                        <div class="mt-10">
                            <input type="number" name="Mask_Admin" placeholder="Admin" min="1"
                                onfocus="this.placeholder = ''" onblur="this.placeholder = 'Admin'" required
                                class="single-input" runat="server" id="MaskAdmin">
                        </div>

                        <div class="mt-10">
                            <asp:Button ID="btn_UpdateMask" runat="server" Text="Update Mask Type" class="genric-btn primary-border" OnClick="UpdateMask_Click" />
                        </div>

                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="" Visible="false"></asp:Label>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
