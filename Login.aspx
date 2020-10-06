<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
         <div class="whole-wrap">
        <div class="container box_1170">
          <!--  container box_1170-->
            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Login</h3>

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
                        <div class="mt-10">
                            <asp:Button ID="login" class="log-btn" runat="server" Text="Login" />
                            <a href="Register.aspx" class="btn btn-secondary py-3 px-4">Register</a>
                        </div>
                        <div class="mt-10">
                            <asp:Label ID="error" runat="server" Text="Incorrect Password or Username" visible="false" ></asp:Label>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
     </form>
</asp:Content>
