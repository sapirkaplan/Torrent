<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to Turrent </h1>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; yaron and sapir</div>
        <div style="height: 232px; width: 987px">

            
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/regrestion.aspx">Regrestion</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Manager.aspx">Admin</asp:HyperLink>

            
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/OnlineUsers.aspx">Online users</asp:HyperLink>

            
        </div>
    </form>
</body>
</html>
