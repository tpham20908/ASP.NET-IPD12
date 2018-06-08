<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer Detail Order.aspx.cs" Inherits="DataSources1.Customer_Detail_Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Customer Description:</h2>
            <p>
                <asp:DropDownList ID="ddl" runat="server" AutoPostBack="True" DataSourceID="SqlCustomerFields" DataTextField="COLUMN_NAME" DataValueField="COLUMN_NAME">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlCustomerFields" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString2 %>" 
                    SelectCommand="SELECT COLUMN_NAME
FROM Northwnd.INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = N'Customers'"></asp:SqlDataSource>
            </p>
            
            <p>
                <asp:TextBox ID="tbx" runat="server" Width="246px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlAllCustomers" Width="464px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateColumns="False" DataKeyNames="CustomerID">
                    <Columns>
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
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
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlAllCustomers" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString2 %>" 
                    SelectCommand="SELECT * FROM [Customers] WHERE ([CustomerID] = @CustomerID)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="tbx" DefaultValue="null" Name="CustomerID" 
                            PropertyName="Text" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </p>

        </div>
    </form>
</body>
</html>
