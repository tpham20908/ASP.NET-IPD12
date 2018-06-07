<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataSources1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Dropdown list binding<br />
            <br />
            <asp:DropDownList ID="ddlBinding" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblDDLBinding" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
