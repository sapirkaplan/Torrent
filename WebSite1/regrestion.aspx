<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regrestion.aspx.cs" Inherits="regrestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="direction: ltr">
            <h1>Registration</h1>
                <asp:Label ID="LabelUserName" runat="server" Text="User Name :"></asp:Label>
                &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxUserName" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
                <asp:Label ID="LabelPassword" runat="server" Text="Password :"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="signIn" runat="server" Text="Sign in" OnClick="signIn_Click" />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HomePage.aspx">back to Home Page</asp:HyperLink>
        </div>
    </form>
</body>
</html>
