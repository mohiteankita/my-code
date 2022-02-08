<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableDemo.aspx.cs" Inherits="PracticeAsp.TableDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell BackColor="Yellow">Name</asp:TableCell>
                <asp:TableCell BackColor="Pink">
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click"/></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>State</asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="dropdownstate" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dropdownstate_SelectedIndexChanged">
                      
                    </asp:DropDownList></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
    <p>
        <input id="Hidden1" runat="server" type="hidden" value="XZ"/>
    </p>
</body>
</html>
