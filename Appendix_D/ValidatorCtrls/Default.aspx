<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Fun with ASP.NET Validators"></asp:Label>
        <hr />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Required Field:"></asp:Label><br />
        <asp:TextBox ID="txtRequiredField" runat="server" Width="160px">Please enter your name</asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtRequiredField"
            ErrorMessage="Oops!  Need to enter data." 
          InitialValue="Please enter your name" Display="None"></asp:RequiredFieldValidator><br />
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Range 0 - 100:"></asp:Label><br />
            <asp:TextBox ID="txtRange" runat="server" Width="157px"></asp:TextBox>
            &nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtRange"
                ErrorMessage="Please enter value between 0 and 100." MaximumValue="100" MinimumValue="0"
                Type="Integer" Display="None"></asp:RangeValidator><br />
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Enter your US SSN"></asp:Label><br />
                <asp:TextBox ID="txtRegExp" runat="server" Width="156px"></asp:TextBox>
                &nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtRegExp"
                    ErrorMessage="Please enter a valid US SSN." 
                  ValidationExpression="\d{3}-\d{2}-\d{4}" Display="None"></asp:RegularExpressionValidator><br />
                <br />
                <div>
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Value < 20"></asp:Label><br />
                    <asp:TextBox ID="txtComparison" runat="server" Width="153px"></asp:TextBox>
                    &nbsp;
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtComparison"
                        ErrorMessage="Enter a value less than 20." Operator="LessThan" 
                      ValueToCompare="20" Display="None" Type="Integer"></asp:CompareValidator><br />
                    <br />
                    <br />
                    <asp:Button ID="btnPostback" runat="server" OnClick="btnPostback_Click" Text="Post back" />
                    &nbsp;
                    
                    <asp:Label ID="lblValidationComplete" runat="server"></asp:Label>
                    <br />
                      
                    <asp:ValidationSummary id="ValidationSummary1"                      
                        runat="server" Width="353px"
                        HeaderText="Here are the things you must correct.">
                      </asp:ValidationSummary>
                      
                </div>
                <br />
            </div>
            <br />
        </div>        
    </div>
    </form>
</body>
</html>
