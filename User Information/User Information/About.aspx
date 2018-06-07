<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="User_Information.About" %>

<%@ Register src="UserControls/UserInfoBoxControl.ascx" tagname="Info" tagprefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc3:Info runat="server" ID="UserInfo" UserName="John Doe" UserAge="33" UserCountry="Canada"/>
        </div>
    </form>
</body>
</html>
