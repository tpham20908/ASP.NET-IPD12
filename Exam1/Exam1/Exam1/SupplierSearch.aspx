<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierSearch.aspx.cs" Inherits="Exam1.SupplierSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 161px;
        }
        .auto-style3 {
            width: 268px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Supplier Search:</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"><h4>Company Name:</h4></td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlSuppliers" runat="server" Height="24px" Width="189px" 
                            AppendDataBoundItems="True" DataSourceID="SqlCompanyNames" 
                            DataTextField="CompanyName" DataValueField="SupplierID" 
                            OnSelectedIndexChanged="ddlSuppliers_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlCompanyNames" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT [CompanyName], [SupplierID] FROM [Suppliers]"></asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"><h4>City:</h4></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxCity" runat="server" Width="177px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search by City" Width="155px" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" DataKeyNames="SupplierID" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="DSOSuppliers" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="266px">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" SortExpression="SupplierID" />
                                <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                                <asp:BoundField DataField="ContactName" HeaderText="ContactName" SortExpression="ContactName" />
                                <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" SortExpression="ContactTitle" />
                                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                                <asp:BoundField DataField="HomePage" HeaderText="HomePage" SortExpression="HomePage" />
                            </Columns>
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView>
                        <asp:ObjectDataSource ID="DSOSuppliers" runat="server" SelectMethod="GetSuppliersByCity" TypeName="Exam1.BAL.BAL_Suppliers">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="tbxCity" DefaultValue="null" Name="cityName" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                        <asp:ObjectDataSource ID="DSSuppliers" runat="server"></asp:ObjectDataSource>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
