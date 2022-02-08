<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormToGetStudDetails.aspx.cs" Inherits="LoginFormDemo.FormToGetStudDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            background-color : lightgray;
        }
        .auto-style1 {
            width: 100%;
            margin: 80px 0px 0px 300px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            font-size: x-large;
            color: #000066;
        }
        .auto-style4 {
            width: 399px;
            height: 26px;
        }
        .auto-style5 {
            width: 399px;
            text-align: left;
        }
        .auto-style6 {
            height: 26px;
            text-align: left;
        }
        .auto-style7 {
            text-align: left;
        }
    </style>
</head>
<body>
    <div class="auto-style2">
        <strong>
    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style3">Registration Form</asp:Label>
        </strong>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">First Name:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TxtFname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtFname" runat="server" ErrorMessage="**Please Enter First Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Last Name:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TxtLname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">User Name:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TxtUname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TxtUname" runat="server" ErrorMessage="**Please Enter User Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Password:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">DOB:</td>
            <td>
                <asp:Calendar ID="CalDob" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Gender:</td>
            <td class="auto-style7">
                <asp:RadioButton ID="RdoMale" runat="server" GroupName="GrpGender" Text="Male" />
                <asp:RadioButton ID="RdoFemale" runat="server" GroupName="GrpGender" Text="Female" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Educational Qualification:</td>
            <td class="auto-style7">
                <asp:DropDownList ID="DropDownEdn" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>BTech</asp:ListItem>
                    <asp:ListItem>BE Computer Science</asp:ListItem>
                    <asp:ListItem>ME Computer Science</asp:ListItem>
                    <asp:ListItem>Bsc Mathematics</asp:ListItem>
                    <asp:ListItem>Msc Mathematics</asp:ListItem>
                    <asp:ListItem>Bsc Statistics</asp:ListItem>
                    <asp:ListItem>Msc Statistics</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Hobbies</td>
            <td class="auto-style7">
                <asp:CheckBox ID="ChkRead" runat="server" Text="Reading" />
                <asp:CheckBox ID="ChkDance" runat="server" Text="Dancing" />
                <asp:CheckBox ID="ChkSing" runat="server" Text="Singing" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Button ID="SubmitBtn" OnClick="SubmitBtn_Click" runat="server" Text="Submit" />
            </td>
            <td class="auto-style6">
                <asp:Button ID="BtnReset" runat="server" Text="Reset" />
            </td>
        </tr>
    </table>
        <div>
        </div>
    </form>
    </div>
</body>
</html>
