<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="ASP_App.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblWelcome" runat="server" Text="Welcome, press the button for a surprise!"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
        <asp:Button ID="btnPrint" runat="server" OnClick="btnPrint_Click" Text="Print" />
    </form>
</body>
</html>
