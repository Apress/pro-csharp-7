<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun with Session State"></asp:Label><br />
        <hr />
        <asp:Label ID="Label2" runat="server" Text="Which color?"></asp:Label>
        <asp:TextBox ID="txtCarColor" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Which Make?"></asp:Label>
        <asp:TextBox ID="txtCarMake" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Down Payment?"></asp:Label>
        <asp:TextBox ID="txtDownPayment" runat="server"></asp:TextBox><br />
        <br />
        <asp:CheckBox ID="chkIsLeasing" runat="server" Text="Lease?" /><br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Delivery Date:"></asp:Label>
        <br />
        <br />
        <asp:Calendar ID="myCalendar" runat="server" BackColor="White" BorderColor="#3366CC"
            BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
            Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <WeekendDayStyle BackColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
        </asp:Calendar>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" /><br />
        <br />
        <asp:Label ID="lblUserID" runat="server"></asp:Label><br />
        <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
