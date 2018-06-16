<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="NewMedia.aspx.cs" Inherits="VideoRentalStore.NewMedia" %>

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
        <h1 class="text-center">New Media</h1>
    </div>
    
    <div class="row">
        <div class="col-sm-3"></div>
        <div class="col-sm-6">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Media Info:</h4>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Title:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tbxTitle" runat="server" Width="95%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                                    ForeColor="Red" ControlToValidate="tbxTitle" ></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Type:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tbxType" runat="server" Width="95%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                                    ForeColor="Red" ControlToValidate="tbxType" ></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Production Year:" Width="100%"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="tbxYear" runat="server" Width="95%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                                    ForeColor="Red" ControlToValidate="tbxYear" ></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                </div>
                <div class="card-footer">
                    <asp:Button ID="btnAddNewMedia" runat="server" Text="Add New Media" 
                        Width="100%" CssClass="bg-info" ForeColor="White" OnClick="btnAddNewMedia_Click" />
                </div>
            </div>
        </div>
        <div class="col-sm-3"></div>
    </div>
</asp:Content>
