<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="DataAspDotNet.Repeater" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate> Location Data
            <br />
            <table border="1">
      <thead>
          <th>Location ID</th>
          <th>Street Address</th>
          <th>Postal Code</th>
          <th>State</th>
      </thead>
        </HeaderTemplate>
            <ItemTemplate>
                <tr style="background-color:bisque">
                    <td>
                     <asp:Label ID="Label1" runat="server" Text='<%#Bind("Location_ID")%>'></asp:Label></td>
                   <td> <asp:Label ID="Label2" runat="server" Text='<%#Bind("Street_Address")%>'></asp:Label></td>
                    <td><asp:Label ID="Label3" runat="server" Text='<%#Bind("Postal_Code")%>'></asp:Label></td>
                   <td> <asp:Label ID="Label4" runat="server" Text='<%#Eval("State_Province")%>'></asp:Label></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                 <tr style="background-color:aqua">
                    <td>
                    <asp:Label ID="Label1" runat="server" Text='<%#Bind("Location_ID")%>'></asp:Label></td>
                   <td> <asp:Label ID="Label2" runat="server" Text='<%#Bind("Street_Address")%>'></asp:Label></td>
                   <td> <asp:Label ID="Label3" runat="server" Text='<%#Bind("Postal_Code")%>'></asp:Label></td>
                   <td> <asp:Label ID="Label4" runat="server" Text='<%#Eval("State_Province")%>'></asp:Label></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                <td colspan="4">
                    End of Report
                </td>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HRMSDBConnectionString6 %>" SelectCommand="SELECT * FROM [LOCATIONS]"></asp:SqlDataSource>
        
        <br /><br /><br />
        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource2">
            <HeaderTemplate>
                <tr>
                    Locations Information
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
                LOCATION_ID:
                <asp:Label ID="LOCATION_IDLabel" runat="server" BackColor="violet" Text='<%# Eval("LOCATION_ID") %>' />
                <br />
                STREET_ADDRESS:
                <asp:Label ID="STREET_ADDRESSLabel" runat="server" BackColor="violet" Text='<%# Bind("STREET_ADDRESS") %>' />
                <br />
                POSTAL_CODE:
                <asp:Label ID="POSTAL_CODELabel" runat="server" BackColor="violet" Text='<%# Bind("POSTAL_CODE") %>' />
                <br />
                CITY:
                <asp:Label ID="CITYLabel" runat="server" BackColor="violet" Text='<%# Bind("CITY") %>' />
                <br />
                STATE_PROVINCE:
                <asp:Label ID="STATE_PROVINCELabel" runat="server" BackColor="violet" Text='<%# Bind("STATE_PROVINCE") %>' />
                <br />
                COUNTRY_ID:
                <asp:Label ID="COUNTRY_IDLabel" runat="server" BackColor="violet" Text='<%# Bind("COUNTRY_ID") %>' />
                <br />
                
            </ItemTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HRMSDBConnectionString7 %>" SelectCommand="SELECT * FROM [LOCATIONS]"></asp:SqlDataSource>
    </form>
</body>
</html>
