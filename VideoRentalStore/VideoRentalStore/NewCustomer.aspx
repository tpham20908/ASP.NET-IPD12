<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="VideoRentalStore.NewCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="jumbotron">
        <h1 class="text-center">New Customer</h1>
    </div>
    <div class="row">
        <div class="col-sm-3"></div>
        <div class="col-sm-6">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Customer Info:</h4>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="lblFirstName" runat="server" Text="First Name:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tbxFirstName" runat="server" Width="95%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="*" ControlToValidate="tbxFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblLastName" runat="server" Text="Last Name:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tbxLastName" runat="server" Width="95%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ErrorMessage="*" ControlToValidate="tbxLastName" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblAddress" runat="server" Text="Address:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tbxAddress" runat="server" Width="95%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ErrorMessage="*" ControlToValidate="tbxAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone number:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tbxPhoneNumber" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="card-footer">
                    <asp:Button ID="btnAddNewCustomer" runat="server" Text="Add New Customer" 
                        Width="100%" OnClick="btnAddNewCustomer_Click" CssClass="bg-info" ForeColor="White" />
                </div>
            </div>
        </div>
        <div class="col-sm-3"></div>
    </div>
</asp:Content>
