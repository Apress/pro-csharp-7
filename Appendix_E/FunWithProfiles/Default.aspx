<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <hr />
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Fun with Profiles"></asp:Label><br />
        <hr />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Street Address"></asp:Label>
        <asp:TextBox ID="txtStreetAddress" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="State"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="txtState" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit Data" 
      onclick="btnSubmit_Click" /><br />
        <br />
        <asp:Label ID="lblUserData" runat="server"></asp:Label>
    </form>
</body>
</html>
