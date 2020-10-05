<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="InvoiceForClient.aspx.cs" Inherits="Group_MaskInc_FrontEnd.InvoiceForClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="AllInvoice-page">
        <div class="container">
            <div class="AllInvoice-table">
                <table>
                    <thead>
                        <tr>
                            <th class="client-name">Name</th>
                            <th>Date of purchase</th>
                            <th class="quan">Quantity</th>
							<th class="status">Status</th>
                            <th>Total</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody runat="server" id="AllInvoiceID"></tbody>
                </table>
            </div>

            <!------------------------- BUTTON ------------------------->
            <div class="invoice-btn">
                <div class="row">
                    <div class="col-lg-5 offset-lg-1 text-left text-lg-right">
                        <a href="Home.aspx" class="site-btn update-btn">Go Back</a>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- END CLIENT INVOICE PAGE-->

</asp:Content>
</asp:Content>
