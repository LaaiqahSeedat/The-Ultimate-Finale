<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1><i class="fa fa-cart-plus"></i>&nbsp;Catalogue</h1>
    <hr />
    <div class="row">
        <div class="col-md-9">
        </div>
        <div class="col-md-1"><label><strong>PRICES: </strong></label></div>
        <div class="col-md-2">
            <select class="form-control" onchange="Prizes()" id="prices" runat="server">
                <option value="P1">R0 - R25</option>
                <option value="P2">R26 - R50</option>
                <option value="P3">R51 - R150</option>
                <option value="P4">R151 - R1000</option>
                <option value="P5">R1001 - R10000</option>      
            </select>
        </div>
    </div>
        <div class="row">
        <div class="col-md-9">
        </div>
        <div class="col-md-1"><label><strong>SIZES: </strong></label></div>
        <div class="col-md-2">
            <select class="form-control" onchange="Size()" id="sizes" runat="server">
                <option value="S1">Kids 2-6</option>
                <option value="S2">Kids 7-14</option>
                <option value="S3">Youth</option>
                <option value="S4">Ladies</option>
                <option value="S5">Mens</option>      
            </select>
        </div>
    </div>
    <hr />
    <!-- Catalogue will come in here -->
    <div id="cat" runat="server">

    </div>
    <hr />
    <div class="row">
        <div class="col-md-12">
        </div>
    </div>
   
</asp:Content>
