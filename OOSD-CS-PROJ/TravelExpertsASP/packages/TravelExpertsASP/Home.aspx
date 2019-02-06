<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TravelExpertsASP.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/bootstrapLux.css" rel="stylesheet" />
    <link href="Styles/nav.css" rel="stylesheet" />
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
                        <li><a href="http://localhost:61652/Login.aspx">Log In</a></li>
                        <li><a href="http://localhost:61652/Register.aspx">Register</a></li>

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
            <h4>About Us:</h4>
            <p>We are located in Calgary, with a branch office in Okotoks and we plan to open new agencies in the future.  
                The agency has an easy-to-operate system for customers, suppliers, sales and commissions. 
                We offer the best packages for our customers. Our Agents are friendly and offer the best packages for our customers,
                not only that they are the ones who help customers anytime they need them.
                In addition, we offer deals for our existing customers and our suppliers are happy to help any time a customer or agent needs them.
            </p>
            <br />
            <br />
            <h4>Contact Us:</h4>
            <p>We are happy to help anytime, anywhere!</p>
            <p>123 street Calgary, Alberta</p>
            <p>Phone: (403) 666-6666</p>
            <p>Email: Travel@Experts.ca</p>
        </div>
    </form>
    <footer class="container-fluid text-center footerDiv">
			<p>This page copyrighted &copy; by Travel Experts</p>
		</footer>
</body>
</html>
