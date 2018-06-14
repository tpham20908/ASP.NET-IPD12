<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="TimeTracker.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Employees:</h3>
            <p>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
                    BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="DSEmployees" 
                    Width="484px" DataKeyNames="ID">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                        <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                        <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                        <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
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
                <asp:ObjectDataSource ID="DSEmployees" runat="server" SelectMethod="GetEmployees" TypeName="TimeTracker.Models.TimeTrackerRepository"></asp:ObjectDataSource>
            </p>
            <h3>Time Cards:</h3>
            <p>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style1" DataSourceID="DSTimeCards" Width="286px">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="SubmissionDate" HeaderText="SubmissionDate" SortExpression="SubmissionDate" />
                        <asp:BoundField DataField="MondayHours" HeaderText="MondayHours" SortExpression="MondayHours" />
                        <asp:BoundField DataField="TuesdayHours" HeaderText="TuesdayHours" SortExpression="TuesdayHours" />
                        <asp:BoundField DataField="WednesdayHours" HeaderText="WednesdayHours" SortExpression="WednesdayHours" />
                        <asp:BoundField DataField="ThursdayHours" HeaderText="ThursdayHours" SortExpression="ThursdayHours" />
                        <asp:BoundField DataField="FridayHours" HeaderText="FridayHours" SortExpression="FridayHours" />
                        <asp:BoundField DataField="SaturdayHours" HeaderText="SaturdayHours" SortExpression="SaturdayHours" />
                        <asp:BoundField DataField="SundayHours" HeaderText="SundayHours" SortExpression="SundayHours" />
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
                <asp:ObjectDataSource ID="DSTimeCards" runat="server" SelectMethod="GetTimeCards" TypeName="TimeTracker.Models.TimeTrackerRepository">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridView1" Name="empId" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </p>
        </div>
    </form>
</body>
</html>
