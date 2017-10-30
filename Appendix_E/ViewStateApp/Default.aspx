<%@ Page EnableViewState ="false" Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Fun with View State"></asp:Label><br />
        <hr />
        &nbsp;</div>
        <asp:ListBox ID="myListBox" runat="server">
        </asp:ListBox><br />
        <br />
        <asp:Button ID="btnPostback" runat="server" OnClick="btnPostback_Click" Text="Submit" />&nbsp;<br />
        <br />
        <asp:Button ID="btnAddToVS" runat="server" OnClick="btnAddToVS_Click" Text="Add Value to ViewState" /><br />
        <br />
        <asp:Label ID="lblVSValue" runat="server"></asp:Label>
    </form>
</body>
</html>
