<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun with Application State"></asp:Label><br />
        <br />
        <hr />
        <br />
        <asp:Button ID="btnShowAppVariables" runat="server" OnClick="btnShowAppVariables_Click"
            Text="Show App Variables" /><br />
        <br />
        <asp:Label ID="lblAppVariables" runat="server"></asp:Label><br />
        <br />
        <br />
        <asp:Button ID="btnSetNewSP" runat="server" OnClick="btnSetNewSP_Click" Text="Set New Sales Person" />
        <asp:TextBox ID="txtNewSP" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
