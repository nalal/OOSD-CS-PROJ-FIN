<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelExpertsASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/bootstrapLux.css" rel="stylesheet" />
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
                        <li class="nav-item active">
                            <a class="nav-link" href="http://localhost:61652/Login.aspx">Home <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="http://localhost:61652/UserAccountDetails.aspx">Features</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="http://localhost:61652/UserAccountDetails.aspx">Pricing</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="http://localhost:61652/UserAccountDetails.aspx">About</a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <div class="jumbotron">
            <div class="container">
                <h1 class="display-1">Hello!!!</h1>
                <h3 class="display-3">Name</h3>
            </div>
        </div>
        <div>
        </div>
    </form>
    <footer class="footer">
        <div class="container">
            <span class="text-muted">Place sticky footer content her.</span>
        </div>
    </footer>
</body>
</html>
