<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="AddAdmin.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
    <div class="whole-wrap">
        <div class="container box_1170">

            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Add Admin</h3>

                        <h5 class="mt-10">User Id</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                              
                                class="single-input" runat="server" id="UserId">
                        </div>
                        
                        <h5 class="mt-10">Surname</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                             
                                class="single-input" runat="server" id="Surname">
                        </div>
                        <div class="mt-10">
                            <asp:Button ID="bt_register" runat="server" Text="Add Admin" class="genric-btn primary-border" OnClick="btn_register()" />
                        </div>
                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="" visible="false" ></asp:Label>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</asp:Content>
