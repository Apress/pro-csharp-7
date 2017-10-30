<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationGroups.aspx.cs" Inherits="ValidationGroups" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
  <asp:Panel ID="Panel1" runat="server" Height="83px" Width="447px">
    <asp:TextBox ID="txtRequiredData" runat="server" 
         ValidationGroup="FirstGroup"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
         ErrorMessage="*Required field!" ControlToValidate="txtRequiredData"
         ValidationGroup="FirstGroup">
    </asp:RequiredFieldValidator>
    <asp:Button ID="bntValidateRequired" runat="server" 
         OnClick="bntValidateRequired_Click"
         Text="Validate" ValidationGroup="FirstGroup" />
  </asp:Panel>

  <asp:Panel ID="Panel2" runat="server" Height="119px" Width="446px">
    <asp:TextBox ID="txtSSN" runat="server" 
         ValidationGroup="SecondGroup"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
         runat="server" ControlToValidate="txtSSN"
         ErrorMessage="*Need SSN" ValidationExpression="\d{3}-\d{2}-\d{4}" 
         ValidationGroup="SecondGroup">
    </asp:RegularExpressionValidator>&nbsp;
    <asp:Button ID="btnValidateSSN" runat="server" 
         OnClick="btnValidateSSN_Click" Text="Validate"
         ValidationGroup="SecondGroup" />
  </asp:Panel>

</form>

</body>
</html>
