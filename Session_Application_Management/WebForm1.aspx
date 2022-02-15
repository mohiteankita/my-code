<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Session_Application_Management.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Name:
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnNext" runat="server" OnClick="BtnNext_Click" Text="Next" />
        </div>
    </form>
</body>
</html>
