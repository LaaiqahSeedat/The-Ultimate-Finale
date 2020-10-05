<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="Group_MaskInc_FrontEnd.EditProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="EditProduct_Page">
        <div class="container">
            <div class="EditProduct_Table">
                <table>
                    <thead>
                        <tr>
                            <th class="ediProduct">Edit Product</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class="Pro_Name">
                            Product Name:<td>
                                <input type="text" placeholder="Product name" required runat="server" id="ProName"></td>
                        </tr>

                        <tr>
                            <td class="Pro_Description">
                            Product Description:<td>
                                <input type="text" placeholder="Product description" required runat="server" id="ProDescription"></td>
                        </tr>

                        <tr>
                            <td class="Pro_Price">
                            Product Price:<td>
                                <input type="number" placeholder="Product price" required min="1" runat="server" id="ProPrice"></td>
                        </tr>

                        <tr>
                            <td class="Pro_Category">
                            Product Category:<td>
                                <select class="Cat_option" name="category" required runat="server" id="ProCategory">
                                    <option disabled="disabled" selected="selected">---Choose Category</option>
                                    <option value="1">Kids</option>
                                    <option value="2">Casual</option>
                                    <option value="3">Nano</option>
                                    <option value="4">Cultural</option>
                                </select></td>
                        </tr>

                        <tr>
                            <td class="Pro_Active">
                            Product Activation Status:<td>
                                <select class="Act_option" name="active" required runat="server" id="ProActive">
                                    <option disabled="disabled" selected="selected">---Choose status</option>
                                    <option value="1">Active</option>
                                    <option value="2">Not active</option>
                                </select></td>
                        </tr>

                        <tr>
                            <td class="Pro_Quantity">
                            Product Quantity:<td>
                                <input type="number" placeholder="Product quantity" required min="1" runat="server" id="ProQuantity"></td>
                        </tr>

                        <!---ERROR MESSAGE --->
                        <tr>
                            <td class="Error">
                            Error Message:<td>
                                <input type="text" visible="false" runat="server" id="error"></td>
                        </tr>

                    </tbody>
                </table>

                <!-- BUTTONS: -->

                 <div class="edit-button">
                    <div class="col-lg-5 offset-lg-1 text-left text-lg-right">
                        <div class="site-btn clear-btn" onclick="UpdateProduct_Click">Edit Product</div>
                    </div>
                </div>

            </div>
        </div>
    </div>
<!-- END EDIT PRODUCT PAGE -->
</asp:Content>
