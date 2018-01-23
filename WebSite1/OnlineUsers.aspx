<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OnlineUsers.aspx.cs" Inherits="OnlineUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="User_Name" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="User_Name" HeaderText="User_Name" ReadOnly="True" SortExpression="User_Name" />
                <asp:BoundField DataField="Ip" HeaderText="Ip" SortExpression="Ip" />
                <asp:BoundField DataField="Port" HeaderText="Port" SortExpression="Port" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DBTorrent %>" SelectCommand="SELECT * FROM [Online_Users]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Refresh" />
        <br />
    
    </div>
    </form>
</body>
</html>
