<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="TravelExpertsASP.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome..."></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />
            <br />
            <br />
            <asp:Button ID="btnAccountDetails" runat="server" OnClick="btnAccountDetails_Click" Text="AccountDetails" />
        </div>
    </form>
</body>
</html>
