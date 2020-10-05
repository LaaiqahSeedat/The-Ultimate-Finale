<%@ Page Title="" Language="C#" MasterPageFile="~/MaskInc.Master" AutoEventWireup="true" CodeBehind="AdminSection.aspx.cs" Inherits="Group_MaskInc_FrontEnd.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


		<section class="ftco-appointment ftco-section ftco-no-pt ftco-no-pb img">
		<div class="overlay"></div>
		<div class="container">
			<div class="row">
				<div class="col-md-5 order-md-last d-flex align-items-stretch">
					<div class="donation-wrap">
						<div class="total-donate d-flex align-items-center">
							<span class="fa flaticon-cleaning"></span>
							<h4>Admin Edit section </h4>
							
						</div>
						<form action="#" class="appointment" runat="server">
							<div class="row">
								<div class="col-md-12">
									<div class="form-group">
										<input id="Button9" type="button" value="Add MaskType" runat="server" text="Donate Now" class="btn btn-secondary py-3 px-4" onclick="BtnSubmit_Click" />
									</div>
								</div>
								<div class="col-md-12">
									<div class="form-group">
										<input id="Button8" type="button" value="Add Product    " runat="server" text="Donate Now" class="btn btn-secondary py-3 px-4" onclick="BtnSubmit_Click" /></div>
								</div>
								<div class="col-md-12">
									<div class="form-group">
										<input id="Button7" type="button" value="Add PSize        " runat="server" text="Donate Now" class="btn btn-secondary py-3 px-4" onclick="BtnSubmit_Click" /></div>
								</div>
								<div class="col-md-12">
								<div class="form-group">
										<input id="Button6" type="button" value="Add Size          " runat="server" text="Donate Now" class="btn btn-secondary py-3 px-4" onclick="BtnSubmit_Click" /></div>
								</div>
								<div class="col-md-12">
									<div class="form-group">
								    <input id="Button1" type="button" value="Incase               " runat="server" text="Donate Now" class="btn btn-secondary py-3 px-4" onclick="BtnSubmit_Click" /></div>
									</div>
								<div class="col-md-12">
									<div class="form-group">
										<input id="Button5" type="button" value="Incase               " runat="server" text="Donate Now" class="btn btn-secondary py-3 px-4" onclick="BtnSubmit_Click" /></div>
								</div>
							</div>
						</form>
					</div>
				</div>
				<div class="col-md-7 wrap-about py-5">
					<div class="heading-section pr-md-5 pt-md-5">
						
						<span class="subheading">Welcome to maskInc</span>
						<h2 class="mb-4">Admin </h2>
						<p>This is the most protected and contains high level protected information. The company has trusted you under outh that whatever you add here is of the basis and protocol of the company.Any action taking place here should be true and valid , Content has been recorded</p>
					</div>
			
					<div class="row my-md-5">
						<div class="col-md-6 d-flex counter-wrap">
							<div class="block-18 d-flex">
								<div class="icon d-flex align-items-center justify-content-center">
									<span class="flaticon-volunteer"></span>
								</div>
								<div class="desc">
									<div class="text">
										<strong class="number" data-number="50"></strong>
									</div>
									<div class="text">
										<span></span>
									</div>
								</div>
							</div>
						</div>
						<div class="col-md-6 d-flex counter-wrap">
							<div class="block-18 d-flex">
								<div class="icon d-flex align-items-center justify-content-center">
									<span class="flaticon-piggy-bank"></span>
								</div>
								<div class="desc">
									<div class="text">
										<strong class="number" data-number="24400"></strong>
									</div>
									<div class="text">
										<span></span>
									</div>
								</div>
							</div>
						</div>
					</div>
					<p><a href="#" class="btn btn-secondary btn-outline-secondary">Incase we need a button</a></p>
				</div>
			</div>
		</div>
	</section>
</asp:Content>
