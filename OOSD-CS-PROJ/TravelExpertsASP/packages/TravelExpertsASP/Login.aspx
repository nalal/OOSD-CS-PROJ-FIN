<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelExpertsASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/bootstrapLux.css" rel="stylesheet" />
    <link href="Styles/nav.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>

  <%--  <link href="Styles/Main.css" rel="stylesheet" />--%>
    <title></title>
   <%-- <style type="text/css">
        .auto-style1 {
            width: 212px;
        }
        .auto-style2 {
            
            width: 212px;
            height: 27px;
        }
        .auto-style3 {
            height: 27px;
        }
        .table {
            margin-left:23%;
            width: 49%;
            border:hidden;
            border-bottom:hidden;
        }
        .auto-style4 {
            width: 49%;
            border-collapse: collapse;
            height: 53px;
            border-style: hidden;
            border-color: inherit;
            border-width: medium;
            margin-left: 23%;
            margin-bottom: 1rem;
            background-color: transparent;
        }
    </style>--%>
    <style type="text/css">
        .auto-style3 {
            width: 54%;
            margin-right: 0px;
            margin-left: 25%;
        }
        .auto-style4 {
            width: 39%;
            margin-right: 0px;
            margin-left: 25%;
        }
        .auto-style5 {
            width: 39%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <%--<div class="navbar navbar-expand-lg fixed-top navbar-light bg-light">
      <div class="container">
        <a href="../" class="navbar-brand">Bootswatch</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarResponsive">
          <ul class="navbar-nav">
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" id="themes">Themes <span class="caret"></span></a>
              <div class="dropdown-menu" aria-labelledby="themes">
                <a class="dropdown-item" href="../default/">Default</a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="../cerulean/">Cerulean</a>
                <a class="dropdown-item" href="../cosmo/">Cosmo</a>
                <a class="dropdown-item" href="../cyborg/">Cyborg</a>
                <a class="dropdown-item" href="../darkly/">Darkly</a>
                <a class="dropdown-item" href="../flatly/">Flatly</a>
                <a class="dropdown-item" href="../journal/">Journal</a>
                <a class="dropdown-item" href="../litera/">Litera</a>
                <a class="dropdown-item" href="../lumen/">Lumen</a>
                <a class="dropdown-item" href="../lux/">Lux</a>
                <a class="dropdown-item" href="../materia/">Materia</a>
                <a class="dropdown-item" href="../minty/">Minty</a>
                <a class="dropdown-item" href="../pulse/">Pulse</a>
                <a class="dropdown-item" href="../sandstone/">Sandstone</a>
                <a class="dropdown-item" href="../simplex/">Simplex</a>
                <a class="dropdown-item" href="../sketchy/">Sketchy</a>
                <a class="dropdown-item" href="../slate/">Slate</a>
                <a class="dropdown-item" href="../solar/">Solar</a>
                <a class="dropdown-item" href="../spacelab/">Spacelab</a>
                <a class="dropdown-item" href="../superhero/">Superhero</a>
                <a class="dropdown-item" href="../united/">United</a>
                <a class="dropdown-item" href="../yeti/">Yeti</a>
              </div>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="../help/">Help</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="http://blog.bootswatch.com">Blog</a>
            </li>
            <li class="nav-item dropdown show">
              <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="http://localhost:61652/User.aspx" id="download" aria-expanded="true">User <span class="caret"></span></a>
              <div class="dropdown-menu" aria-labelledby="download">
                <a class="dropdown-item" href="http://localhost:61652/UserAccountDetails.aspx">Account</a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="../4/lux/bootstrap.min.css">bootstrap.min.css</a>
                <a class="dropdown-item" href="../4/lux/bootstrap.css">bootstrap.css</a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="../4/lux/_variables.scss">_variables.scss</a>
                <a class="dropdown-item" href="../4/lux/_bootswatch.scss">_bootswatch.scss</a>
              </div>
            </li>
          </ul>

          <ul class="nav navbar-nav ml-auto">
            <li class="nav-item">
              <a class="nav-link" href="http://localhost:61652/Login.aspx" target="_blank">Login</a>
            </li>
          </ul>

        </div>
      </div>
   <%-- </div>--%>
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
   <%-- <form class="form-inline my-2 my-lg-0">--%>
    
    <%--</form>--%>

            <%--<div class="navbar navbar-expand-lg navbar-dark bg-primary">
                <div class="container">
                    
                    <a href="../" class="navbar-brand">TravelExperts</a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
   
               <nav>
                   <div class="collapse navbar-collapse" id="navbarColor01">
                    <ul>
                        <li><a href="http://localhost:61652/Login.aspx">Log In</a></li>
                        <li><a href="http://localhost:61652/Register.aspx">Register</a></li>
                        <li><a href="http://localhost:61652/User.aspx">Account</a></li>
                        <li><a href="http://localhost:61652/Login.aspx">Logout</a></li>
                    </ul>
                       </div>
                </nav>--%>
                   <%--  </div>
      </div>
          --%>
       <br />
        <br />
        <div class="container">
            <h5 class="label">
                <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label></h5>
            <br />
            <div class="form-group">
                
                    &nbsp;
                    &nbsp;<table class="auto-style1" border="0">
                        <tr>
                            <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblCustUserName" class="bold" runat="server" Text="User Name:" Font-Bold="True" ForeColor="Black"></asp:Label>
                            </td>
                            <td class="auto-style3"><asp:TextBox ID="txtCustUserName" class="form-control" runat="server" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;</td>
                            <td>
                    <asp:RequiredFieldValidator ID="rfvCustUserName" runat="server" ControlToValidate="txtCustUserName" ErrorMessage="User Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblCustPassword" runat="server" Text="Password: " Font-Bold="True" ForeColor="Black"></asp:Label></td>
                            <td>
                    <asp:TextBox ID="txtCustPassword" class="form-control" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">&nbsp;</td>
                            <td>
                    <asp:RequiredFieldValidator ID="rfvCustPassword" runat="server" ControlToValidate="txtCustPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
            </div>
            <br />
            <asp:Button ID="btnLogin" class="textbox" runat="server" OnClick="btnLogin_Click" Text="Login" />
            &nbsp;or
        <asp:HyperLink ID="hlSignUp" runat="server" NavigateUrl="~/Register.aspx">Sign Up</asp:HyperLink>
        </div>
    </form>
    <br />
    <footer class="container-fluid text-center footerDiv">
			<p>This page copyrighted &copy; by Travel Experts</p>
		</footer>
</body>
</html>
