<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="DataAspDotNet.GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="COUNTRY_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="COUNTRY_ID" HeaderText="COUNTRY_ID" ReadOnly="True" SortExpression="COUNTRY_ID" />
                <asp:BoundField DataField="COUNTRY_NAME" HeaderText="COUNTRY_NAME" SortExpression="COUNTRY_NAME" />
                <asp:BoundField DataField="REGION_ID" HeaderText="REGION_ID" SortExpression="REGION_ID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HRMSDBConnectionString4 %>" SelectCommand="SELECT * FROM [COUNTRIES]"></asp:SqlDataSource>
        
    </form>
</body>
</html>
