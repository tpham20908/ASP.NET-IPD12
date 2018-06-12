<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LINQ_Practice.aspx.cs" Inherits="DataSources1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CSS/Style.css" />
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
            <br />
            <br />
            <asp:Label ID="lblBindingEvent" runat="server"></asp:Label>
            <br />
            <br />
            <h2>This Box Binding</h2>
            <p>
                <asp:ListBox ID="lbxTowns" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID" OnSelectedIndexChanged="lbxTowns_SelectedIndexChanged"></asp:ListBox>
            </p>
            <p>
                <asp:Label ID="lblTown" runat="server"></asp:Label>
            </p>
            <h2>Bulleted List</h2>
            <asp:BulletedList ID="bltSearch" runat="server" DataTextField="Name" DataValueField="URL" DisplayMode="HyperLink">
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
