<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="LoginFormDemo.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Validate() {
            var username = document.getElementById("TxtUname").value;
            var pwd = document.getElementById("TxtPass").value;

            if (username == "" && pwd == "")
            {
                alert("Please Enter User Name & Password");
                return false;
            }

            if (username == "")
            {
                alert("Please Enter Username Name")
                return false;
            }
           

            if (pwd == "")
            {
                alert("Please Enter Password")
                return false;
            }
      
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table>
            <tr>
                <td class="auto-style2">User Name:</td>
                <td><asp:TextBox ID="TxtUname" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td class="auto-style2">Password</td>
                <td><asp:TextBox ID="TxtPass" TextMode="Password" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td colspan="2"><asp:Button ID="BtnSubmit" Text="Submit" runat="server" OnClick="BtnRegi_Click" OnClientClick="return Validate();"/></td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
