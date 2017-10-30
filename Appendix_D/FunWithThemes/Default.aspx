<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default"  %>

<!DOCTYPE>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <h1>
        Fun with Themes</h1>
      <hr />
      <br />
      <asp:Button ID="btnNoTheme" runat="server" onclick="btnNoTheme_Click" 
        Text="No Theme" />
&nbsp;<asp:Button ID="btnGreenTheme" runat="server" onclick="btnGreenTheme_Click" 
        Text="Green Theme" />
&nbsp;<asp:Button ID="btnOrangeTheme" runat="server" onclick="btnOrangeTheme_Click" 
        Text="Orange Theme" />
      <br />
      <hr />
      <br />
    
      Here are the controls which will be themed.<br />
      <br />
      <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
      <br />
      <asp:Button ID="Button1" runat="server" Text="Button" />
      <br />
      <br />
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <br />
      <br />
    <asp:Button ID="Button2" runat="server"
      SkinID="BigFontButton" Text="Big Font!" /><br />

    </div>
    </form>
</body>
</html>
