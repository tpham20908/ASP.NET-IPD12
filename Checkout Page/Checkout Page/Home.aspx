<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" 
    Inherits="Checkout_Page.Home" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css/Style.css" rel="stylesheet" />
    <title>Checkout</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Check Out Page</h1>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                CssClass="validationSummary" HeaderText="Please correct these entries" />
            <br />
            <h2>Contact Information</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Email Address:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxEmail" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="tbxEmail" ErrorMessage="Email address" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" >
                            Must be a valid email address
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email Re-entry:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxReEmail" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ErrorMessage="Email re-entry"
                            ControlToValidate="tbxReEmail" ControlToCompare="tbxEmail"
                            operator="Equal" Type="String" >
                            Must match first email address
                        </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">First Name:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxFirstName" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ErrorMessage="First Name"
                            controltovalidate="tbxFirstName">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxLastName" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ErrorMessage="Last Name"
                            controltovalidate="tbxLastName">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone Number:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxPhoneNumber" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ErrorMessage="Phone number"
                            controltovalidate="tbxPhoneNumber"
                            ValidationExpression="^\d{3}-\d{3}-\d{4}$">
                            Use this format: 123-456-7890
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
            <h2>Billing Address</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Address:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxBillingAddress" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ErrorMessage="Billing Address" 
                            ControlToValidate="tbxBillingAddress">Required</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxBillingCity" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ErrorMessage="Billing City"
                            ControlToValidate="tbxBillingCity">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">State:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlBillingState" runat="server" CssClass="dropdownList" 
                            DataTextField="Name" DataValueField="ID" >
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>WA</asp:ListItem>
                            <asp:ListItem>VA</asp:ListItem>
                            <asp:ListItem>MI</asp:ListItem>
                            <asp:ListItem>LA</asp:ListItem>
                            <asp:ListItem>FL</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ErrorMessage="Billing State" Display="Dynamic" 
                            ControlToValidate="ddlBillingState" InitialValue="">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Zip code:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxBillingZip" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ErrorMessage="Billing Zip code"
                            ControlToValidate="tbxBillingZip">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <h2>Shipping Address</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:CheckBox ID="ckbxSameAddress" runat="server" 
                            Text="Same as billing address" AutoPostBack="true" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Address:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxShippingAddress" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ErrorMessage="Shipping Address"
                            ControlToValidate="tbxShippingAddress">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxShippingCity" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                            ErrorMessage="Shipping City"
                            ControlToValidate="tbxShippingCity">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">State:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlShippingState" runat="server" CssClass="dropdownList" DataTextField="Name" DataValueField="ID">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>WA</asp:ListItem>
                            <asp:ListItem>VA</asp:ListItem>
                            <asp:ListItem>MI</asp:ListItem>
                            <asp:ListItem>LA</asp:ListItem>
                            <asp:ListItem>FL</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                            ErrorMessage="Shipping State"
                            ControlToValidate="ddlShippingState">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Zip code:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxShippingZip" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                            ErrorMessage="Shipping Zip code"
                            ControlToValidate="tbxShippingZip">Required
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="btn">
                        <asp:Button ID="btnCheckout" runat="server" Text="Check Out" OnClick="btnCheckout_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <div class="lblOrderDetail">
                <h5>Order Detail:</h5>
                <asp:Label ID="lblSummary" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
