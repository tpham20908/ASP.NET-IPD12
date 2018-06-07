<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LunchOrder.aspx.cs" Inherits="DataSources1.LunchOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/Style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Lunch Order</h2>
            <table class="auto-style1">
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="tbxName" runat="server" Width="215px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:ListBox ID="lbxCity" runat="server" OnSelectedIndexChanged="lbxCity_SelectedIndexChanged"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:DropDownList ID="ddlGender" runat="server" OnSelectedIndexChanged="ddlGender_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Meal Options</td>
                    <td>
                        <asp:CheckBoxList ID="cbxMeal" runat="server" OnSelectedIndexChanged="cbxMeal_SelectedIndexChanged">
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                    <td>Payment</td>
                    <td>
                        <asp:RadioButtonList ID="rbtnPayment" runat="server" OnSelectedIndexChanged="rbtnPayment_SelectedIndexChanged">
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOrder" runat="server" OnClick="btnOrder_Click" Text="Order" />
            <br />
            <br />
            <asp:ListBox ID="lbxDetail" runat="server" Width="621px"></asp:ListBox>
            <br />
            
        </div>
    </form>
</body>
</html>
