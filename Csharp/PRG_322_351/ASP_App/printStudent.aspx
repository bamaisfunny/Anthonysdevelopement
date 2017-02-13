<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="printStudent.aspx.cs" Inherits="ASP_App.printStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        You have been Redirected!</div>
        <asp:Button ID="btnStudentInfo" runat="server" OnClick="btnStudentInfo_Click" Text="Get Student Info" />
        <div style="margin-left: 160px">
            <asp:Label ID="lblStudent" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
