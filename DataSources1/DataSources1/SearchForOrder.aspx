<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForOrder.aspx.cs" Inherits="DataSources1.SearchForOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 201px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">

            <asp:TextBox ID="tbxOrderID" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlOptions" runat="server" Height="16px" Width="193px" >
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Customer</asp:ListItem>
                            <asp:ListItem>Shipper</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DetailsView ID="dtlResult" runat="server" Height="50px" Width="367px"></asp:DetailsView>
                    </td>
                    <td>
                        <asp:ListBox ID="lbxResult" runat="server" Width="318px"></asp:ListBox>
                    </td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
