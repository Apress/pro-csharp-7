<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic Control Test</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
    <hr />
    <h1>Dynamic Controls</h1>
        <h1>
            <asp:Button ID="btnAddWidgets" runat="server" OnClick="btnAddWidgets_Click" 
                Text="Add Widgets" />
            <asp:Button ID="btnClearPanel" runat="server" OnClick="btnClearPanel_Click" 
                Text="Clear All Widgets" />
        </h1>
        <p>
            <asp:Button ID="btnGetTextData" runat="server" OnClick="btnGetTextData_Click" 
                Text="Get Text Data" />
        </p>
        <p>
            <asp:Label ID="lblTextBoxData" runat="server"></asp:Label>
        </p>
    <asp:Label ID="lblTextBoxText" runat="server"></asp:Label>
    <hr />
    </div>

    <!-- The Panel has three contained controls -->
    <asp:Panel ID="myPanel" runat="server" Width="200px" 
         BorderColor="Black" BorderStyle="Solid" >
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
      <asp:Button ID="Button1" runat="server" Text="Button"/><br/>
      <asp:HyperLink ID="HyperLink1" runat="server">HyperLink
      </asp:HyperLink>
    </asp:Panel>
  <br />
  <br />
  <asp:Label ID="lblControlInfo" runat="server"></asp:Label>
</form>
</body>
</html>
