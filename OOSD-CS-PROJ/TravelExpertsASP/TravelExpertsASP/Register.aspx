<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TravelExpertsASP.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/bootstrapLux.css" rel="stylesheet" />
    <link href="Styles/nav.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <title></title>

    <style type="text/css">
        
        .auto-style2 {
            width: 140px;
        }
        .auto-style3 {
            width: 345px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <%--<header>
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
        <div class="slideshow-container">

            <div class="mySlides fade">
                <img class="slideImg" src="Images/c.jpg" style="width: 80%; margin-left: 10%" />
            </div>

            <div class="mySlides fade">
                <img class="slideImg" src="Images/e.jpg" style="width: 80%; margin-left: 10%" />
            </div>

            <div class="mySlides fade">
                <img class="slideImg" src="Images/j3.jpg" style="width: 80%; margin-left: 10%" />
            </div>

            <div class="mySlides fade">
                <img class="slideImg" src="Images/p.jpg" style="width: 80%; margin-left: 10%" />
            </div>

        </div>
         <br/>
        <div style="text-align: center">
            <span class="dot"></span>
            <span class="dot"></span>
            <span class="dot"></span>
            <span class="dot"></span>
        </div>

        <script>
            var slideIndex = 0;
            showSlides();

            function showSlides() {
                var i;
                var slides = document.getElementsByClassName("mySlides");
                var dots = document.getElementsByClassName("dot");
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = "none";
                }
                slideIndex++;
                if (slideIndex > slides.length) { slideIndex = 1 }
                for (i = 0; i < dots.length; i++) {
                    dots[i].className = dots[i].className.replace(" active", "");
                }
                slides[slideIndex - 1].style.display = "block";
                dots[slideIndex - 1].className += " active";
                setTimeout(showSlides, 2000); // Change image every 2 seconds
            }
        </script>--%>

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
            <div class="rowroindex">
                <h4 class="label">Register:</h4>
            </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustFirstName" runat="server" Text="First Name:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustFirstName" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustFirstName" runat="server" ErrorMessage="First name is required" ControlToValidate="txtCustFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustLastName" runat="server" Text="Last Name:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustLastName" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustLastName" runat="server" ErrorMessage="Last name is required" ControlToValidate="txtCustLastName" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustAddress" runat="server" Text="Address:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustAddress" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustAddress" runat="server" ControlToValidate="txtCustLastName" ErrorMessage="Address is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustCity" runat="server" Text="City:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustCity" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustCity" runat="server" ControlToValidate="txtCustCity" ErrorMessage="City is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustProv" runat="server" Text="Province:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:DropDownList ID="ddlCustProv" class="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="False" Width="300px">
                        <asp:ListItem Selected="True" Text="" Value=""></asp:ListItem>
                        <asp:ListItem>AB</asp:ListItem>
                        <asp:ListItem>BC</asp:ListItem>
                        <asp:ListItem>SK</asp:ListItem>
                        <asp:ListItem>MB</asp:ListItem>
                        <asp:ListItem>ON</asp:ListItem>
                        <asp:ListItem>QC</asp:ListItem>
                        <asp:ListItem>NS</asp:ListItem>
                        <asp:ListItem>PE</asp:ListItem>
                        <asp:ListItem>NB</asp:ListItem>
                        <asp:ListItem Value="YT"></asp:ListItem>
                        <asp:ListItem>NT</asp:ListItem>
                        <asp:ListItem>NU</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustProv" runat="server" ControlToValidate="ddlCustProv" ErrorMessage="Province is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustPostal" runat="server" Text="Postal Code:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustPostal" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustPostal" runat="server" ErrorMessage="Postal Code is required" ForeColor="Red" ControlToValidate="txtCustPostal"></asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="revCustPostal" runat="server" ControlToValidate="txtCustPostal" ErrorMessage="Invalid postal code format" ValidationExpression="^[A-Y]{1}[0-9]{1}[A-Z]{1}[ ]?[0-9]{1}[A-Z]{1}[0-9]{1}$" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustCountry" runat="server" Text="Country:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:DropDownList ID="ddlCustCountry" class="form-control" AppendDataBoundItems="true" runat="server" Width="300px">
                        <asp:ListItem Selected="True" Text="" Value=""></asp:ListItem>
                        <asp:ListItem>CAN</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustCountry" runat="server" ErrorMessage="Country is required" ControlToValidate="ddlCustCountry" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustHomePhone" runat="server" Text="Home Phone:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustHomePhone" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustHomePhone" runat="server" ControlToValidate="txtCustHomePhone" ErrorMessage="Home phone number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCustHomePhone" runat="server" ControlToValidate="txtCustHomePhone" ErrorMessage="Invalid phone number format" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustBusPhone" runat="server" Text="Business Phone:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustBusPhone" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RegularExpressionValidator ID="revCustBusPhone" runat="server" ControlToValidate="txtCustBusPhone" ErrorMessage="Invalid phone number format" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustEmail" runat="server" Text="Email:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustEmail" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RegularExpressionValidator ID="revCustEmail" runat="server" ControlToValidate="txtCustEmail" ErrorMessage="Invalid email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustUserName" runat="server" Text="User Name:" Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustUserName" class="form-control" runat="server" AutoPostBack="False" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustUserName" runat="server" ControlToValidate="txtCustUserName" ErrorMessage="User Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustPassword" runat="server" Text="Password: " Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustPassword" class="form-control" runat="server" AutoPostBack="False" TextMode="Password" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:RequiredFieldValidator ID="rfvCustPassword" runat="server" ErrorMessage="Password is required" ControlToValidate="txtCustPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Password must contain one upper case character, lower case character, number, and special character. It must be between 8-15 characters long." ForeColor="Red" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&amp;])[A-Za-z\d@$!%*?&amp;]{8,}$" ControlToValidate="txtCustPassword"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:Label ID="lblCustRePassword" runat="server" Text="Re-enter Password: " Font-Bold="True" ForeColor="Black"></asp:Label></td>
                    <td class="auto-style3"><asp:TextBox ID="txtCustRePassword" class="form-control" runat="server" AutoPostBack="False" TextMode="Password" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                    <asp:CompareValidator ID="cvPasswords" runat="server" ControlToCompare="txtCustPassword" ControlToValidate="txtCustRePassword" ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                </table>
            <br />
            <br />
            
<%--                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;</p>
            </div>
            <br />
            <br />
            <br />
            <div class="form-group">
                <h5 class="label">
                    &nbsp;</h5>
                <p class="textbox">
                    &nbsp;&nbsp;&nbsp;
                </p>
            </div>--%>
            <br />
            <br />
            <asp:Button ID="btnCustRegister" class="textbox" runat="server" OnClick="btnCustRegister_Click" Text="Register" />
            <br />
            <br />
        </div>
    </form>
    <br />
    <footer class="container-fluid text-center footerDiv">
        <p>This page copyrighted &copy; by Travel Experts</p>
    </footer>
</body>
</html>
