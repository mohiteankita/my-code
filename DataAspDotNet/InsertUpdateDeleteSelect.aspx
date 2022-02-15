<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUpdateDeleteSelect.aspx.cs" Inherits="DataAspDotNet.InsertUpdateDeleteSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="LOCATION_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" ShowSelectButton="True" ShowDeleteButton="True" />
                <asp:BoundField DataField="LOCATION_ID" HeaderText="LOCATION_ID" ReadOnly="True" SortExpression="LOCATION_ID" />
                <asp:BoundField DataField="STREET_ADDRESS" HeaderText="STREET_ADDRESS" SortExpression="STREET_ADDRESS" />
                <asp:BoundField DataField="POSTAL_CODE" HeaderText="POSTAL_CODE" SortExpression="POSTAL_CODE" />
                <asp:BoundField DataField="CITY" HeaderText="CITY" SortExpression="CITY" />
                <asp:BoundField DataField="STATE_PROVINCE" HeaderText="STATE_PROVINCE" SortExpression="STATE_PROVINCE" />
                <asp:BoundField DataField="COUNTRY_ID" HeaderText="COUNTRY_ID" SortExpression="COUNTRY_ID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" UpdateCommand="Update_Location_Details" UpdateCommandType="StoredProcedure" DeleteCommand="Delete_Location_Details" DeleteCommandType="StoredProcedure" runat="server" ConnectionString="<%$ ConnectionStrings:HRMSDBConnectionString2 %>" SelectCommand="SELECT * FROM [LOCATIONS]"></asp:SqlDataSource>
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="LOCATION_ID" DataSourceID="SqlDataSource2">
            <EditItemTemplate>
                LOCATION_ID:
                <asp:Label ID="LOCATION_IDLabel1" runat="server" Text='<%# Eval("LOCATION_ID") %>' />
                <br />
                STREET_ADDRESS:
                <asp:TextBox ID="STREET_ADDRESSTextBox" runat="server" Text='<%# Bind("STREET_ADDRESS") %>' />
                <br />
                POSTAL_CODE:
                <asp:TextBox ID="POSTAL_CODETextBox" runat="server" Text='<%# Bind("POSTAL_CODE") %>' />
                <br />
                CITY:
                <asp:TextBox ID="CITYTextBox" runat="server" Text='<%# Bind("CITY") %>' />
                <br />
                STATE_PROVINCE:
                <asp:TextBox ID="STATE_PROVINCETextBox" runat="server" Text='<%# Bind("STATE_PROVINCE") %>' />
                <br />
                COUNTRY_ID:
                <asp:TextBox ID="COUNTRY_IDTextBox" runat="server" Text='<%# Bind("COUNTRY_ID") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                LOCATION_ID:
                <asp:TextBox ID="LOCATION_IDTextBox" runat="server" Text='<%# Bind("LOCATION_ID") %>' />
                <br />
                STREET_ADDRESS:
                <asp:TextBox ID="STREET_ADDRESSTextBox" runat="server" Text='<%# Bind("STREET_ADDRESS") %>' />
                <br />
                POSTAL_CODE:
                <asp:TextBox ID="POSTAL_CODETextBox" runat="server" Text='<%# Bind("POSTAL_CODE") %>' />
                <br />
                CITY:
                <asp:TextBox ID="CITYTextBox" runat="server" Text='<%# Bind("CITY") %>' />
                <br />
                STATE_PROVINCE:
                <asp:TextBox ID="STATE_PROVINCETextBox" runat="server" Text='<%# Bind("STATE_PROVINCE") %>' />
                <br />
                COUNTRY_ID:
                <asp:TextBox ID="COUNTRY_IDTextBox" runat="server" Text='<%# Bind("COUNTRY_ID") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                LOCATION_ID:
                <asp:Label ID="LOCATION_IDLabel" runat="server" Text='<%# Eval("LOCATION_ID") %>' />
                <br />
                STREET_ADDRESS:
                <asp:Label ID="STREET_ADDRESSLabel" runat="server" Text='<%# Bind("STREET_ADDRESS") %>' />
                <br />
                POSTAL_CODE:
                <asp:Label ID="POSTAL_CODELabel" runat="server" Text='<%# Bind("POSTAL_CODE") %>' />
                <br />
                CITY:
                <asp:Label ID="CITYLabel" runat="server" Text='<%# Bind("CITY") %>' />
                <br />
                STATE_PROVINCE:
                <asp:Label ID="STATE_PROVINCELabel" runat="server" Text='<%# Bind("STATE_PROVINCE") %>' />
                <br />
                COUNTRY_ID:
                <asp:Label ID="COUNTRY_IDLabel" runat="server" Text='<%# Bind("COUNTRY_ID") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource2" InsertCommand="Insert_Location_Details" InsertCommandType="StoredProcedure" runat="server" ConnectionString="<%$ ConnectionStrings:HRMSDBConnectionString %>" SelectCommand="SELECT * FROM [LOCATIONS] WHERE ([LOCATION_ID] = @LOCATION_ID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" DefaultValue="1000" Name="LOCATION_ID" PropertyName="SelectedValue" Type="Decimal" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
