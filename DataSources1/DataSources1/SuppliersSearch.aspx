<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SuppliersSearch.aspx.cs" Inherits="DataSources1.SuppliersSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 263px;
        }
        .auto-style3 {
            width: 113px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Supplier ID:</h2>
            <asp:Label ID="lblConnection" runat="server" ForeColor="#0099ff" ></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Supplier ID</td>
                    <td class="auto-style2">
            <asp:TextBox ID="tbxSupplierID" runat="server" Width="233px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:ListBox ID="lbxSuppliers" runat="server" Width="246px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSuppliers" runat="server" Height="21px" Width="191px" OnSelectedIndexChanged="ddlSuppliers_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:DetailsView ID="dvSupplier" runat="server" Height="50px" Width="243px">
                        </asp:DetailsView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
