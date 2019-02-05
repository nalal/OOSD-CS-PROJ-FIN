<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="TravelExpertsASP.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/Main.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="container">
                <img src="Images/l2.png" alt="logo" class="img-responsive" />
                <nav>
                    <ul>
                        <li><a href="http://localhost:61652/Login.aspx">Log In</a></li>
                        <li><a href="http://localhost:61652/Register.aspx">Register</a></li>
                    </ul>
                </nav>
            </div>
        </header>
        <div class="container">
            <h5 class="label">
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome..."></asp:Label></h5>
            <br />
            <br />
            <asp:Button ID="btnLogout" class="textbox" runat="server" OnClick="btnLogout_Click" Text="Logout" />
            <br />
            <br />
            <asp:Button ID="btnAccountDetails" class="textbox" runat="server" OnClick="btnAccountDetails_Click" Text="AccountDetails" />
            <asp:Button ID="btnPurchasedProducts" class="textbox" runat="server" OnClick="btnPurchasedProducts_Click" Text="Purchased Products" />
        </div>
    </form>
</body>
</html>
