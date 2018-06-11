<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForOrder_Home.aspx.cs" Inherits="DataSources1.SearchForOrder_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 24px;
        }
        .auto-style2 {
            width: 221px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Search for Order:</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"><h3>Order Id: </h3></td>
                    <td>
                        <asp:TextBox ID="tbxOrderId" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><h3>Search for: </h3></td>
                    <td>
                        <asp:DropDownList ID="ddlOptions" runat="server" Width="200px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Customer</asp:ListItem>
                            <asp:ListItem>Shipper</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" Width="200px" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="lbxOption" runat="server" Width="200px" Height="80px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:DetailsView ID="dvResult" runat="server" Height="50px" Width="400px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                            <EditRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" ForeColor="#003399" />
                        </asp:DetailsView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
