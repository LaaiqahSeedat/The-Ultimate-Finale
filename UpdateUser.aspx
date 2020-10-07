<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
    <div class="whole-wrap">
        <div class="container box_1170">
            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Update User Information</h3>

                         <h5 class="mt-10">Username</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                              
                                class="single-input" runat="server" id="Username">
                        </div>
                        <h5 class="mt-10">Company name</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                               
                                class="single-input" runat="server" id="Name">
                        </div>
                        
                         </div>
                        <h5 class="mt-10">Business Type</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                             
                                class="single-input" runat="server" id="BusinessT">
                        </div>
                         <div class="mt-10">
                          
                            <input type="email" name="first_name"
                             
                                class="single-input" runat="server" id="Email">
                        </div>
                                               <h5 class="mt-10">Contact Details</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                               
                                class="single-input" runat="server" id="Contact">
                        </div>
                        <h5 class="mt-10">Address</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                               
                                class="single-input" runat="server" id="Address">
                        </div>

                          <h5 class="mt-10">Password</h5>
                         <div class="mt-10">
                            <input type="Password" name="first_name" 
                               
                                class="single-input" runat="server" id="Password">
                        </div>
                        
                         </div>
                                        <h5 class="mt-10">Confirm Password</h5>
                         <div class="mt-10">
                            <input type="Password" name="first_name" 
                               
                                class="single-input" runat="server" id="ConfirmPassword">
                        </div>
                        
                         </div>
                        <div class="mt-10">
                         <asp:Button ID="btn_update" runat="server" Text="Update User" class="genric-btn primary-border" OnClick="Update_Click" />
                         </div>
                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="" visible="false" ></asp:Label>
                        </div>
                       
                    </div>
                </div>
    </form>
</asp:Content>
