<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqPractice.aspx.cs" 
    Inherits="DataSources1.LinqPractice" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Options:</h3>
            <p>
                <asp:DropDownList ID="ddlOptions" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOptions_SelectedIndexChanged" Height="18px" Width="204px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Students</asp:ListItem>
                    <asp:ListItem>Teachers</asp:ListItem>
                    <asp:ListItem>Courses</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:GridView ID="gvResult" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </p>
            <p>
                <asp:DropDownList ID="ddlDetail" runat="server" Height="16px" Width="206px" OnSelectedIndexChanged="ddlDetail_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Age < 18</asp:ListItem>
                    <asp:ListItem>Teenagers</asp:ListItem>
                    <asp:ListItem>Scored > 80 of last test</asp:ListItem>
                    <asp:ListItem>Total scores > 320</asp:ListItem>
                    <asp:ListItem>No score < 60</asp:ListItem>
                    <asp:ListItem>Grouped by first letter of the last name</asp:ListItem>
                    <asp:ListItem>Average score of each test</asp:ListItem>
                    <asp:ListItem>Students who are also teachers</asp:ListItem>
                    <asp:ListItem>Courses of a duration of 15 weeks</asp:ListItem>
                    <asp:ListItem>Courses held in the Winter semester (order by duration)</asp:ListItem>
                    <asp:ListItem>Courses grouped by semester</asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                <asp:GridView ID="dvDetail" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </p>
        </div>
    </form>
</body>
</html>
