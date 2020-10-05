<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="EditCustomProduct.aspx.cs" Inherits="Group_MaskInc_FrontEnd.EditCustomProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="EditCustomProduct_Page">
        <div class="container">
            <div class="EditCustomProduct_Table">
                <table>
                    <thead>
                        <tr>
                            <th class="editCustomProduct">Edit Custom Product</th>
                        </tr>
                    </thead>
                    <tbody>

                        <tr>
                            <td class="Filter-One">
                            Filter:<td>
                                <select class="Filter_option" name="filter" required runat="server" id="Filter_Option">
                                    <option disabled="disabled" selected="selected">---Choose</option>
                                    <option value="1">Yes</option>
                                    <option value="2">No</option>
                                </select></td>
                        </tr>

                        <tr>
                            <td class="Pro_Size">
                            Product Size:<td>
                                <input type="text" runat="server" id="size" required></td>
                        </tr>

                        <tr>
                            <td class="Pro_Colour">
                            Product Colour:<td>
                                <input type="Text" runat="server" id="colour" required></td>
                        </tr>

                        <tr>
                            <td class="Pro_Logo">
                            Product Logo:<td>
                                <input type="file" name="Upload" accept="image/*" runat="server" id="Upload_Logo">
                                         </td>
                        </tr>

                        <!-- ERROR MESSAGE -->
                        <tr>
                            <td class="Error">
                            Error Message:<td>
                                <input type="text" runat="server" id="error" visible="false"></td>
                        </tr>

                    </tbody>
                </table>

                <!-- BUTTON: -->

                 <div class="editCustom-button">
                    <div class="col-lg-5 offset-lg-1 text-left text-lg-right">
                        <div class="site-btn clear-btn" onclick="EditCustomProduct_Click">Edit Custom Product</div>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <!--- END EDIT CUSTOM PRODUCT PAGE --->
</asp:Content>
