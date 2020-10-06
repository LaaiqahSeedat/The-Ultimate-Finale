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
                        <h3 class="mb-30">User Regististration</h3>

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
                        <h5 class="mt-10">Business Type</h5>
                         <div class="mt-10">
                            <input type="text" name="first_name" 
                             
                                class="single-input" runat="server" id="Surname">
                        </div>
                          <h5 class="mt-10">Email</h5>
                        <div class="mt-10">
                          
                            <input type="email" name="first_name"
                             
                                class="single-input" runat="server" id="Email">
                        </div>
                        <h5 class="mt-10">Password</h5>
                        <div class="mt-10">
                            <input type="Password" name="last_name" 
                               
                                class="single-input" runat="server" id="Password">
                        </div>
                          <h5 class="mt-10">Confirm Password</h5>
                         <div class="mt-10">
                            <input type="Password" name="last_name" 
                              
                                class="single-input" runat="server" id="ConfirmPass">
                        </div>
                        <div class="mt-10">
                            <input id="Button1" name="Update User" type="button" value="Update User" /></div>
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
