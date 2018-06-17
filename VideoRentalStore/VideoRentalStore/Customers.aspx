<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true"
    CodeBehind="Customers.aspx.cs" Inherits="VideoRentalStore.Customers" MaintainScrollPositionOnPostback="true" %>

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
        <h1 class="text-center">Customers</h1>
    </div>

    <div class="row">
        <div class="col-sm-2"></div>
        <div class="col-sm-8">
            <div class="row">
                <div class="col-sm-12 mb-4">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title">Customer List:</h4>
                            <asp:GridView ID="gvCustomers" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None"
                                BorderWidth="1px" CellPadding="4" AutoGenerateColumns="False" DataSourceID="ODSCustomers"
                                DataKeyNames="ID" Width="100%" OnSelectedIndexChanged="gvCustomers_SelectedIndexChanged">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                                    <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                                </Columns>
                                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" ForeColor="#003399" />
                                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                                <SortedDescendingHeaderStyle BackColor="#002876" />
                            </asp:GridView>
                            <asp:ObjectDataSource ID="ODSCustomers" runat="server" SelectMethod="GetCustomers" TypeName="VideoRentalStore.Models.VideoRentalStoreRepository"></asp:ObjectDataSource>
                        </div>
                    </div>
                </div>

                <div class="col-sm-6">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title">Update:</h4>
                            <table class="auto-style1">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label></td>
                                    <td>
                                        <asp:Label ID="lblId" runat="server"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label2" runat="server" Text="First Name: "></asp:Label></td>
                                    <td>
                                        <asp:TextBox ID="tbxFirstName" runat="server" Width="100%"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label></td>
                                    <td>
                                        <asp:TextBox ID="tbxLastName" runat="server" Width="100%"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label></td>
                                    <td>
                                        <asp:TextBox ID="tbxAddress" runat="server" Width="100%"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label4" runat="server" Text="Phone Number:"></asp:Label></td>
                                    <td>
                                        <asp:TextBox ID="tbxPhoneNumber" runat="server" Width="100%"></asp:TextBox></td>
                                </tr>
                            </table>
                            <asp:Button ID="btnUpdate" runat="server" Text="Update Customer" CssClass="bg-info mt-3"
                                Width="100%" ForeColor="White" OnClick="btnUpdate_Click" />
                        </div>
                    </div>
                </div>

                <div class="col-sm-6">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title">Selected Customer:</h4>
                            <asp:DetailsView ID="dvSelectedCustomer" runat="server" Height="50px" Width="100%" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" AutoGenerateRows="False" DataSourceID="ODSSelectedCustomer">
                                <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                <Fields>
                                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                                    <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                                </Fields>
                                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                <RowStyle BackColor="White" ForeColor="#330099" />
                            </asp:DetailsView>
                            <asp:ObjectDataSource ID="ODSSelectedCustomer" runat="server" SelectMethod="GetCustomerById" TypeName="VideoRentalStore.Models.VideoRentalStoreRepository">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="gvCustomers" Name="id" PropertyName="SelectedValue" Type="Int32" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <asp:Button ID="btnRentMedia" runat="server" Text="Rent Media" CssClass="bg-info mt-3"
                                Width="100%" ForeColor="White" OnClick="btnRentMedia_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-sm-2"></div>
    </div>
</asp:Content>
