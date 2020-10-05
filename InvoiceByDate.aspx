<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="InvoiceByDate.aspx.cs" Inherits="Group_MaskInc_FrontEnd.InvoiceByDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="ClientInvoice_Page">
        <div class="container">
            <div class="ClientInvoice_Table">
			
			<!--- GET DATE OF INVOICE --->
			<table> 
				<thead>
					<tr>
						<th class="InvoiceDate">Date of Invoice</th>
					</tr>
				</thead>
				<tbody>
					<tr>
					<td class="clientInvoiceDate">
                            Invoice Date:<td>
                                <input type="datetime-local" runat="server" id="clientInvoice_date"></td>
                        </tr>
			</table>
			
			<!--- BUTTONS: --->

                 <div class="getInvoice-button">
                    <div class="col-lg-5 offset-lg-1 text-left text-lg-right">
                        <div class="site-btn getInvoice-btn" onclick="GetInvoice_Click">Get Invoice</div>
                    </div>
                </div>
			
			<!--- INVOICE DETAILS --->
                <table>
                    <thead>
                        <tr>
                            <th class="clientInvoice">Client Invoices</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class="clientOrderDate">
                            Order Placed Date:<td>
                                <input type="text" runat="server" id="clientOrder_date" readonly></td>
                        </tr>

                        <tr>
                            <td class="clientOrderStatus">
                            Order Status:<td>
                                <input type="text" runat="server" id="clientOrder_Status" readonly></td>
                        </tr>

                        <tr>
                            <td class="clientOrderTotal">
                            Order Total:<td>
                                <input type="number" runat="server" id="clientOrder_Total" readonly></td>
                        </tr>
						
						<tr>
                            <td class="clientOrderTax">
                            Order Tax:<td>
                                <input type="number" runat="server" id="clientOrder_Tax" readonly></td>
                        </tr>
						
						<tr>
                            <td class="clientOrderDiscount">
                            Order Discount Earned:<td>
                                <input type="number" runat="server" id="clientOrder_Discount" readonly></td>
                        </tr>
						
						<tr>
                            <td class="clientOrderShipping">
                            Order Shipping:<td>
                                <input type="number" runat="server" id="clientOrder_Shipping" readonly></td>
                        </tr>
						
						<tr>
                            <td class="clientOrderQuantity">
                            Order Quantity:<td>
                                <input type="number" min="50" runat="server" id="clientOrder_Quantity" readonly></td>
                        </tr>
						
						<tr>
                            <td class="clientOrderDelivery">
                            Order Delivery:<td>
                                <input type="text" runat="server" id="clientOrder_Delivery" readonly></td>
                        </tr>

                    </tbody>
                </table>

                <!--- BUTTONS: --->

                 <div class="go-button">
                    <div class="col-lg-5 offset-lg-1 text-left text-lg-right">
                        <div class="site-btn go-btn" onclick="GoBack_Click">Go Back</div>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <!-- END INVOICE BY DATE PAGE -->
</asp:Content>
