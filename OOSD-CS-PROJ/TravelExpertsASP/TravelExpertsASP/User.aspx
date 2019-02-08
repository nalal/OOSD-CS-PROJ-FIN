<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="TravelExpertsASP.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/bootstrapLux.css" rel="stylesheet" />
    <link href="Styles/nav.css" rel="stylesheet" />
     <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
                <a class="navbar-brand" href="#">Travel Experts</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarColor01">
                    <ul class="navbar-nav mr-auto">
                        <li><a href="http://localhost:61652/Home.aspx">Home</a></li>
                        <li><a href="http://localhost:61652/UserAccountDetails.aspx">Account Details</a></li>
                        <li><a href="http://localhost:61652/PurchasedItems.aspx">Purchased Items</a></li>
                        <li><a href="http://localhost:61652/Login.aspx">Log Out</a></li>

                    </ul>
                </div>
            </nav>
        </header>
        <div class="jumbotron">
            <div class="container">
                <h1 class="display-1">Welcome!!!</h1>
                <h3 class="display-3">Travel Experts</h3>
            </div>
        </div>
        <div class="container">
            <h5 class="label">
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome..."></asp:Label></h5>
            <br />
            <br />
            <asp:Button ID="btnLogout" class="textbox" runat="server" OnClick="btnLogout_Click" Text="Logout" />
            <br />
            <br />
            <asp:Button ID="btnAccountDetails" class="textbox" runat="server" OnClick="btnAccountDetails_Click" Text="AccountDetails" />
            <br />
            <asp:Button ID="btnPurchasedProducts" class="textbox" runat="server" OnClick="btnPurchasedProducts_Click" Text="Purchased Products" />
        </div>
    </form>
    <br />
    <br />
    <footer class="container-fluid text-center footerDiv">
        <p>This page copyrighted &copy; by Travel Experts</p>
    </footer>
</body>
</html>
