<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Checkout_Page.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" integrity="sha384-WskhaSGFgHYWDcbwN70/dfYBj47jz9qbsMId/iRN3ewGhXQFZCSftd1LZCfmhktB" crossorigin="anonymous"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 24px;
        }
        .auto-style2 {
            width: 187px;
        }
        .auto-style3 {
            width: 252px;
        }
        .auto-style4 {
            width: 191px;
        }
        .auto-style5 {
            width: 249px;
        }
        .auto-style6 {
            width: 191px;
            height: 26px;
        }
        .auto-style7 {
            width: 249px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Check Out Page</h1>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <h2>Contact Information</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Email Address:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="tbxEmail" ErrorMessage="Must be a valid email address" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" >
                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email Re-entry:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxReEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ErrorMessage="Must match first email address"
                            ControlToValidate="tbxReEmail" ControlToCompare="tbxEmail"
                            operator="Equal" Type="String" >
                        </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">First Name:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxFirstName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ErrorMessage="First Name is required"
                            controltovalidate="tbxFirstName" >
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Last Name:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ErrorMessage="Last Name is required"
                            controltovalidate="tbxLastName">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone Number:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbxPhoneNumber" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ErrorMessage="Use this format: 123-456-7890"
                            controltovalidate="tbxPhoneNumber"
                            ValidationExpression="^\d{3}-\d{3}-\d{4}$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
            <h2>Billing Address</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Address:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxBillingAddress" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ErrorMessage="Billing Address is required" 
                            ControlToValidate="tbxBillingAddress"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">City:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tbxBillingCity" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ErrorMessage="City is required"
                            ControlToValidate="tbxBillingCity">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">State:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlBillingState" runat="server" Width="186px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ErrorMessage="State is required"
                            ControlToValidate="ddlBillingState"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Zip code:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxBillingZip" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ErrorMessage="Zip Code is required"
                            ControlToValidate="tbxBillingZip"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            <h2>Shipping Address</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:CheckBox ID="ckbxSameAddress" runat="server" Text="Same as billing address" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">Address:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxShippingAddress" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ErrorMessage="Address is required"
                            ControlToValidate="tbxShippingAddress"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">City:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxShippingCity" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                            ErrorMessage="City is required"
                            ControlToValidate="tbxShippingCity"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">State:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlShippingState" runat="server" Width="187px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                            ErrorMessage="State is required"
                            ControlToValidate="ddlShippingState"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Zip code:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbxShippingZip" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                            ErrorMessage="Zip is required"
                            ControlToValidate="tbxShippingZip"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnCheckout" runat="server" Text="Check Out" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
