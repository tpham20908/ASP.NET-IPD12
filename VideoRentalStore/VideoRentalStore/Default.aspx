<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VideoRentalStore.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="jumbotron">
        <h1 class="text-center">Video Rental Store</h1>
    </div>

    <div class="row">
        <div class="col-sm-3">
            <div class="card">
                <div class="card-body">
                    <asp:ImageButton ID="imgBtnCustomers" runat="server" PostBackUrl="~/Customers.aspx"
                        ImageUrl="Images/customers.jpg" CssClass="img-fluid" ToolTip="Customers" />
                </div>
                <div class="card-footer">Customers</div>
            </div>
        </div>
        <div class="col-sm-3">
            <div class="card">
                <div class="card-body">
                    <asp:ImageButton ID="imgBtnRentMedia" runat="server" PostBackUrl="~/RentMedia.aspx"
                        ImageUrl="Images/rentMedia.jpg" CssClass="img-fluid" ToolTip="Rent Media" />
                </div>
                <div class="card-footer">Rent Media</div>
            </div>
        </div>
        <div class="col-sm-3">
            <div class="card">
                <div class="card-body">
                    <asp:ImageButton ID="imgBtnNewCustomer" runat="server" PostBackUrl="~/NewCustomer.aspx"
                        ImageUrl="Images/newCustomer.jpg" CssClass="img-fluid" ToolTip="New Customer" />
                </div>
                <div class="card-footer">New Customer</div>
            </div>
        </div>
        <div class="col-sm-3">
            <div class="card">
                <div class="card-body">
                    <asp:ImageButton ID="imgBtnNewMedia" runat="server" PostBackUrl="~/NewMedia.aspx"
                        ImageUrl="Images/newMedia.jpg" CssClass="img-fluid" ToolTip="New Media" />
                </div>
                <div class="card-footer">New Media</div>
            </div>
        </div>
    </div>
</asp:Content>
