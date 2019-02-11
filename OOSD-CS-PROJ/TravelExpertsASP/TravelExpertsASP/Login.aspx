<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelExpertsASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="Styles/bootstrapLux.css" rel="stylesheet" />

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>



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
        .auto-style1 {
            height: 26px;
        }
    </style>
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
        <a class="nav-link" href="Default.aspx">Home <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item">
        <a class="nav-link" href="Register.aspx">Register</a>
      </li>
    </ul>
  
  </div>
</nav>

          
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
            <div class="form-group">
                
                    &nbsp;
                    &nbsp;<table class="auto-style4" border="0">
                        <tr>
                            <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblCustUserName" class="bold" runat="server" Text="User Name:" Font-Bold="True"></asp:Label>
                            </td>
                            <td class="auto-style1"><asp:TextBox ID="txtCustUserName" class="form-control" runat="server" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">&nbsp;</td>
                            <td>
                    <asp:RequiredFieldValidator ID="rfvCustUserName" runat="server" ControlToValidate="txtCustUserName" ErrorMessage="User Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblCustPassword" runat="server" Text="Password: " Font-Bold="True"></asp:Label></td>
                            <td>
                    <asp:TextBox ID="txtCustPassword" class="form-control" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">&nbsp;</td>
                            <td>
                    <asp:RequiredFieldValidator ID="rfvCustPassword" runat="server" ControlToValidate="txtCustPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
            </div>
            <br />
            <div class="container">
                <asp:Button ID="btnLogin" class="textbox" runat="server" OnClick="btnLogin_Click" Text="Login" />
                &nbsp;or
                <asp:HyperLink ID="hlSignUp" runat="server" NavigateUrl="~/Register.aspx">Sign Up</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
