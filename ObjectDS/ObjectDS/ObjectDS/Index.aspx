<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ObjectDS.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Countries List:</h3>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                Height="16px" Width="157px" DataSourceID="DSCountries" AppendDataBoundItems="True" >
            </asp:DropDownList>
            <asp:ObjectDataSource ID="DSCountries" runat="server" SelectMethod="GetAllCountries" TypeName="ObjectDS.BAL.BAL_Countries"></asp:ObjectDataSource>
            <br />
            <h3>List of Customers:</h3>
            <p>
                <asp:GridView ID="gvCustomer" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="139px" 
                    Width="355px" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="DSCustomers" DataKeyNames="CustomerID">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
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
                <asp:ObjectDataSource ID="DSCustomers" runat="server" SelectMethod="GetCustomersByCountry" TypeName="ObjectDS.BAL.BAL_Countries">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="country" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </p>
            <h3>Select Customer Details</h3>
            <p>
                <asp:DetailsView ID="dvCustomerDetails" runat="server" Height="66px" Width="392px" AllowPaging="True" AutoGenerateRows="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="DSCustomer" ForeColor="Black" GridLines="None">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <Fields>
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
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
                    </Fields>
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                </asp:DetailsView>
                <asp:ObjectDataSource ID="DSCustomer" runat="server" SelectMethod="GetCustomer" TypeName="ObjectDS.BAL.BAL_Countries">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="gvCustomer" Name="CustomerID" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </p>
        </div>
    </form>
</body>
</html>
