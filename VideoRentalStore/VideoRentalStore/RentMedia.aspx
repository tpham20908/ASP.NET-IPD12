<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RentMedia.aspx.cs" Inherits="VideoRentalStore.RentMedia" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <div class="jumbotron">
        <h1 class="text-center">Rent Media</h1>
    </div>
    <div class="row">
        <div class="col-sm-6">
            <div class="card">
                <div class="card-body">
                    <div class="card-title">
                        <h4>Search for media title:</h4>
                    </div>
                    <div class="row">
                        <div class="col-sm-9">
                            <asp:TextBox ID="tbxSearchTitle" runat="server" Width="100%" CssClass="pl-1"></asp:TextBox>
                        </div>
                        <div class="col-sm-3">
                            <asp:Button ID="btnSearchTitle" runat="server" Text="Search" Width="100%"
                                CssClass="bg-info" ForeColor="White" OnClick="btnSearchTitle_Click" />
                        </div>
                    </div>

                    <br />
                    <hr />

                    <h4 class="card-title">Media rented:</h4>
                    <asp:GridView ID="gvRentedMedias" runat="server" Width="100%" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODSMediaListByCustomerId">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                            <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                            <asp:BoundField DataField="ProductionYear" HeaderText="ProductionYear" SortExpression="ProductionYear" />
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                    <asp:ObjectDataSource ID="ODSMediaListByCustomerId" runat="server" SelectMethod="GetMediaListByCustomerId" TypeName="VideoRentalStore.Models.VideoRentalStoreRepository">
                        <SelectParameters>
                            <asp:QueryStringParameter DefaultValue="null" Name="customerId" QueryStringField="CustomerId" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
            </div>
        </div>
        <div class="col-sm-6">
            <div class="card">
                <div class="card-body">
                    <div class="card-title">
                        <h4>Found Medias:</h4>
                    </div>
                    <div class="row">
                        <div class="col-sm-8">
                            <asp:CheckBoxList ID="cblTitles" runat="server" Width="100%" DataSourceID="ODSMedias" DataTextField="Title" DataValueField="ID"></asp:CheckBoxList>
                            <asp:ObjectDataSource ID="ODSMedias" runat="server" SelectMethod="GetMediaByTitle" TypeName="VideoRentalStore.Models.VideoRentalStoreRepository">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="tbxSearchTitle" Name="text" PropertyName="Text" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </div>
                        <div class="col-sm-4">
                            <asp:Button ID="btnRent" runat="server" Text="Rent Now" Width="100%"
                                CssClass="bg-info" ForeColor="White" OnClick="btnRent_Click" />
                        </div>
                    </div>
                    <asp:Label ID="lblAnnouncement" runat="server"
                        Font-Italic="true" Font-Bold="true" ForeColor="#996633"></asp:Label>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
