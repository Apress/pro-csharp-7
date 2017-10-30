<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Show Page Event Sequence"></asp:Label><br />
        <br />
        <asp:Button ID="btnPostback" runat="server" OnClick="btnPostback_Click" Text="Postback" />
        <asp:Button ID="btnTriggerError" runat="server" OnClick="btnTriggerError_Click" Text="Trigger Error" /><br />
        <br />
        <asp:Label ID="lblPageEvents" runat="server"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
