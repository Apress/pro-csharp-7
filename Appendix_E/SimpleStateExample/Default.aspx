<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Simple State Example"></asp:Label>
        <hr />
    
    </div>
        <asp:Button ID="btnSetCar" runat="server" OnClick="btnSetCar_Click" Text="Set Favorite Car" />
        <asp:TextBox ID="txtFavCar" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnGetCar" runat="server" OnClick="btnGetCar_Click" Text="Get Favorite Car" />&nbsp;
        <asp:Label ID="lblFavCar" runat="server"></asp:Label>
    </form>
</body>
</html>
