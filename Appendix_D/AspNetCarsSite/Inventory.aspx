<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="InventoryPage"
    Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p>
        Here is our current Inventory!
    </p>
    <p>
        Filter Model Type: 
    <asp:DropDownList ID="cboMake" SelectMethod="GetMakes"
        AppendDataBoundItems="true" AutoPostBack="true"
        DataTextField="Make" DataValueField="Make"
        runat="server">
        <asp:ListItem Value="" Text="(All)" />
    </asp:DropDownList>

    </p>
    <p>
        <asp:GridView ID="carsGrid" runat="server"
            AllowPaging="True" PageSize="2"
            AllowSorting="True" AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="CarID" ItemType="AutoLotDAL.Models.Inventory"
            SelectMethod="GetData" DeleteMethod="Delete" UpdateMethod="Update"
            EmptyDataText="There are no data records to display." ForeColor="#333333"
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="CarID" HeaderText="CarID" ReadOnly="True"
                    SortExpression="CarID" />
                <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
                <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                <asp:BoundField DataField="PetName" HeaderText="PetName"
                    SortExpression="PetName" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
</asp:Content>

