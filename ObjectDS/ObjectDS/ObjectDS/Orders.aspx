<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="ObjectDS.Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Order Date:</h3>
            <p>
                <asp:Calendar ID="Calendar1" runat="server" Height="252px" Width="393px" 
                    BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" 
                    Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" NextPrevFormat="ShortMonth" 
                    VisibleDate="1996-02-01" SelectedDate="1996-02-01">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <DayStyle BackColor="#CCCCCC" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                </asp:Calendar>
            </p>
            <h3>Order By Date:</h3>
            <p>
                <asp:GridView ID="gvOrders" runat="server" Height="111px" Width="400px" BackColor="White" 
                    BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    AllowPaging="True" AutoGenerateColumns="False" DataSourceID="DSOrdersByDate"
                    DataKeyNames="OrderID" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="OrderID" HeaderText="OrderID" SortExpression="OrderID" />
                        <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                        <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" />
                        <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
                        <asp:BoundField DataField="RequiredDate" HeaderText="RequiredDate" SortExpression="RequiredDate" />
                        <asp:BoundField DataField="ShippedDate" HeaderText="ShippedDate" SortExpression="ShippedDate" />
                        <asp:BoundField DataField="ShipVia" HeaderText="ShipVia" SortExpression="ShipVia" />
                        <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight" />
                        <asp:BoundField DataField="ShipName" HeaderText="ShipName" SortExpression="ShipName" />
                        <asp:BoundField DataField="ShipAddress" HeaderText="ShipAddress" SortExpression="ShipAddress" />
                        <asp:BoundField DataField="ShipCity" HeaderText="ShipCity" SortExpression="ShipCity" />
                        <asp:BoundField DataField="ShipRegion" HeaderText="ShipRegion" SortExpression="ShipRegion" />
                        <asp:BoundField DataField="ShipPostalCode" HeaderText="ShipPostalCode" SortExpression="ShipPostalCode" />
                        <asp:BoundField DataField="ShipCountry" HeaderText="ShipCountry" SortExpression="ShipCountry" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:ObjectDataSource ID="DSOrdersByDate" runat="server" SelectMethod="GetOrdersByDate" TypeName="ObjectDS.BAL.BAL_Countries">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="Calendar1" Name="date" PropertyName="SelectedDate" Type="DateTime" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </p>
            <h3>Products:</h3>
            <p>
                <asp:GridView ID="gvProducts" runat="server" Height="105px" Width="402px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="DSProducts">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ProductID" HeaderText="ProductID" SortExpression="ProductID" />
                        <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                        <asp:BoundField DataField="SupplierID" HeaderText="SupplierID" SortExpression="SupplierID" />
                        <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" SortExpression="CategoryID" />
                        <asp:BoundField DataField="QuantityPerUnit" HeaderText="QuantityPerUnit" SortExpression="QuantityPerUnit" />
                        <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                        <asp:BoundField DataField="UnitsInStock" HeaderText="UnitsInStock" SortExpression="UnitsInStock" />
                        <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" SortExpression="UnitsOnOrder" />
                        <asp:BoundField DataField="ReorderLevel" HeaderText="ReorderLevel" SortExpression="ReorderLevel" />
                        <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
                <asp:ObjectDataSource ID="DSProducts" runat="server" SelectMethod="GetProducts" TypeName="ObjectDS.BAL.BAL_Countries">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="gvOrders" Name="id" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ObjectDataSource ID="DSOrderDetail" runat="server"></asp:ObjectDataSource>
            </p>
            <h3>Customed Products:</h3>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
