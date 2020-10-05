<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    

    <section class="page-add">
        <div class="container">
            <div class="row">
                <div class="col-lg-4">
                    <div class="page-breadcrumb">
                        <h2>Checkout<span>.</span></h2>
                    </div>
                </div>
                <div class="col-lg-8">
                    <img src="img/add.jpg" alt="">
                </div>
            </div>
        </div>
    </section>
    <!-- Page Add Section End -->


                
    <!-- Cart Total Page Begin -->
    <section class="cart-total-page spad">
        <div class="container">
            <form action="Payment.aspx" class="checkout-formh" method="get" id="Checkout_Form">
                
                <input type="hidden" name="clientId" value="<%= clientId%>" />
                <div class="row">
                    <div class="col-lg-12">
                        <h3>Your Information</h3>
                    </div>

                      <!--Company Name  -->
                    <div class="col-lg-9">
                        
                  <div class="row">
                       <div class="col-lg-2">
                                <p class="in-name"> Address*</p>
                            </div>
                            <div class="col-lg-10">
                                <textarea class="form-control" name="address"><%= user.Address %></textarea>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-lg-2">
                                <p class="in-name">Shipping*</p>
                            </div>
                            <div class="col-lg-10">
                                    <% foreach (var d in deliveries)
                                    { %>
                                    <input type="radio" name="shipping" value="<%= d.Delivery_Id %>"> <%= d.Name %><br />
                                    <% } %>

                            </div>
                        </div>
               

                    
                </div>
                       
                    <div class="col-lg-3">
                        <div class="order-table">
                            <div class="cart-item">
                                <span>Price(Excl. Tax)</span>
                                <p>R<%= total %></p>
                            </div>
                            <div class="cart-item">
                                <span>Quantity</span>
                                <p><%= quant %></p>
                            </div>
                            <div class="cart-item">
                                <span>Tax</span>
                                <p>R<%= Math.Round(absTot * (decimal)0.15) %></p>
                            </div>
                            <div class="cart-item">
                                <span>Shipping</span>
                                <p>R<%= shipping %></p>
                            </div>
                    <div class="cart-item">
                                <span>Discount</span>
                                <p>-R <%= discount %></p>
                            </div>

                            <div class="cart-total">
                                <span>Total</span>
                                <p>R<%= absTot %></p>
                            </div>
                        </div>
                    </div>
                </div>
            
                <div class="row">
                    <div class="col-lg-12">
                        <div class="payment-method">
                            
                    <button id="Payment_Btn" type="submit">Proceed to Payment</button>
                        </div>
                    </div>
                </div>
            
                </form>    
        </div>

    </section>
    <!-- Cart Total Page End  -->

</asp:Content>
