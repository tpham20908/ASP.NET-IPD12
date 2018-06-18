<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="Exam1.NewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 248px;
        }
        .auto-style3 {
            width: 136px;
        }
        .auto-style4 {
            width: 136px;
            height: 26px;
        }
        .auto-style5 {
            width: 248px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>New Product:</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">ProductName:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tbxName" runat="server" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">QuantityPerUnit:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="tbxQuantity" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tbxQuantity" runat="server" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">UnitPrice:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="tbxUnitPrice" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tbxUnitPrice" runat="server" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tbxUnitPrice" ErrorMessage="Double type" Type="Double" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">UnitsInStock:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxUnitInStock" runat="server" ></asp:TextBox>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style3">UnitsOnOrder:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="tbxUnitsOnOrder" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">OrderLevel:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="tbxOrderLevel" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Discontinued:</td>
                    <td class="auto-style2">
                        <asp:CheckBox ID="cbxDiscontinued" runat="server" />
                    </td>
                    <td>
                        <%--<asp:CompareValidator ID="CompareValidator2" ControlToValidate="Discontinued" runat="server" ErrorMessage="Must be in bit" ForeColor="Red"></asp:CompareValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">

            <asp:DropDownList ID="ddlCategories" runat="server" DataSourceID="SqlCategories" DataTextField="CategoryName" DataValueField="CategoryID" Height="32px" Width="224px" AppendDataBoundItems="True"></asp:DropDownList>
                        <asp:SqlDataSource ID="SqlCategories" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT [CategoryID], [CategoryName] FROM [Categories]"></asp:SqlDataSource>
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="btnAdd" runat="server" Text="Add New Product" Width="182px" OnClick="btnAdd_Click"/>
                    </td>
                    <td>
                        <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2">
                        <a href="SupplierSearch.aspx">Back to Supplier Search</a>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>

            
        </div>
    </form>
</body>
</html>
