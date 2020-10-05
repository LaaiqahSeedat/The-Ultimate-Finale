<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateAdmin.aspx.cs" Inherits="Group_MaskInc_FrontEnd.UpdateAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UpdateAdmin</title>
    <style type="text/css">
        #Button2 {
            height: 46px;
            width: 115px;
        }
        #Password2 {
            height: 40px;
            width: 195px;
        }
        #Password1 {
            height: 36px;
            width: 189px;
        }
        #Text1 {
            height: 38px;
            width: 189px;
        }
        #Text4 {
            height: 40px;
            width: 193px;
        }
        #Text2 {
            height: 41px;
            width: 191px;
        }
        #Text3 {
            height: 38px;
            width: 190px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
    <div class="whole-wrap">
        <div class="container box_1170">

            <div class="section-top-border">
                <div class="row">
                    <div class="col-lg-8 col-md-8">
                        <h3 class="mb-30">Admin Update</h3>

                        <h5 class="mt-10">Username</h5>
                         <div class="mt-10">
                            <input id="Text3" type="text" name="User_name" />
                            
                              
                               
                        </div>
                        <h5 class="mt-10">FirstName</h5>
                         <div class="mt-10">
                            <input id="Text2" type="text" name="first_name"   />
                             
                               
                                
                        </div>
                         <h5 class="mt-10">LastName</h5>
                        <div class="mt-10">
                            <input id="Text4" type="text" name ="LastName"/>
                           
                           
                             
                               
                        </div>
                       
                          <h5 class="mt-10">Email</h5>
                        <div class="mt-10">
                          
                            <input id="Text1" type="email" name="Email"/>
                           
                             
                              
                        </div>
                        <h5 class="mt-10">Password</h5>
                        <div class="mt-10">
                           
                               <input id="Password1" type="password" name ="Password"/>
                               
                        </div>
                          <h5 class="mt-10">Confirm Password</h5>
                         <div class="mt-10">
                           
                              <input id="Password2" type="password" name ="ConfirmPassword" />
                              
                        </div>
                        <div class="mt-10">
                            
                            </div>
                            
                        <div class="mt-10">
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
       <p>
                            
                            <input style="background-color:grey" id="Button2" name="Update Admin" class="log-btn" type="button" value="Update" /></p>
       <p>
                            <asp:Label ID="error" runat="server" Text="" visible="false" ></asp:Label>
                        </p>
    </form>
</body>
</html>
