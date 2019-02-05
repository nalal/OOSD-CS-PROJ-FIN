<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelExpertsASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/Main.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="navbar navbar-expand-lg fixed-top navbar-light bg-light">
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
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="#" id="download">Lux <span class="caret"></span></a>
              <div class="dropdown-menu" aria-labelledby="download">
                <a class="dropdown-item" href="https://jsfiddle.net/bootswatch/8zet8yhz/">Open in JSFiddle</a>
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
    </div>



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
            <li class="nav-item dropdown">
              <a class="nav-link dropdown-toggle" data-toggle="dropdown" href="http://localhost:61652/User.aspx">Account<span class="caret"></span></a>
              <div class="dropdown-menu" aria-labelledby="download">
                <a class="dropdown-item" href="https://jsfiddle.net/bootswatch/8zet8yhz/">Open in JSFiddle</a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="http://localhost:61652/UserAccountDetails.aspx">Account Details</a>
                <a class="dropdown-item" href="http://localhost:61652/PurchasedItems.aspx">Purchases</a>
                <div class="dropdown-divider"></div>
                <a class="dropdown-item" href="../4/lux/_variables.scss">_variables.scss</a>
                <a class="dropdown-item" href="../4/lux/_bootswatch.scss">_bootswatch.scss</a>
              </div>
            </li>
          </ul>

          <ul class="nav navbar-nav ml-auto">
            <li class="nav-item">
              <a class="nav-link" href="https://wrapbootstrap.com/?ref=bsw" target="_blank">WrapBootstrap</a>
            </li>
          </ul>

        </div>
      </div>
    <form id="form1" runat="server">
        <header>
        <%--<%--<%--    <%--<div class="container">
                <img src="Images/l2.png" alt="logo" class="img-responsive" />--%>
                <%--<nav class="navbar navbar-expand-lg navbar-dark bg-primary">
  <a class="navbar-brand" href="#">Navbar</a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarColor01">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Features</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">Pricing</a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="#">About</a>
      </li>
    </ul>
    <form class="form-inline my-2 my-lg-0">
      <input class="form-control mr-sm-2" type="text" placeholder="Search">
      <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
    </form>
  </div>
</nav>--%>
                <%--<nav>
                    <ul>
                        <li><a href="http://localhost:61652/Login.aspx">Log In</a></li>
                        <li><a href="http://localhost:61652/Register.aspx">Register</a></li>
                        <li><a href="http://localhost:61652/User.aspx">Account</a></li>
                        <li><a href="http://localhost:61652/Login.aspx">Logout</a></li>
                    </ul>
                </nav>--%>
           <%-- </div>--%>
        </header>
        </br>
        </br>
        </br>
        </br>
        </br>
        <div class="container">
            <h5 class="label">
                <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label></h5>
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    <asp:Label ID="lblCustUserName" runat="server" Text="User Name:"></asp:Label></h5>
                <p class="textbox">
                    &nbsp;<asp:TextBox ID="txtCustUserName" class="form-control" runat="server" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCustUserName" runat="server" ControlToValidate="txtCustUserName" ErrorMessage="User Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </p>
            </div>
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    <asp:Label ID="lblCustPassword" runat="server" Text="Password: "></asp:Label></h5>
                <p class="textbox">
                    <asp:TextBox ID="txtCustPassword" class="form-control" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCustPassword" runat="server" ControlToValidate="txtCustPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </p>
            </div>
            <br />
            <br />
            <br />
            <asp:Button ID="btnLogin" class="textbox" runat="server" OnClick="btnLogin_Click" Text="Login" />
            &nbsp;or
        <asp:HyperLink ID="hlSignUp" runat="server" NavigateUrl="~/Register.aspx">Sign Up</asp:HyperLink>
        </div>
    </form>
</body>
</html>
