<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelExpertsASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblCustUserName" runat="server" Text="User Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustUserName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCustUserName" runat="server" ControlToValidate="txtCustUserName" ErrorMessage="User Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="lblCustPassword" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtCustPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCustPassword" runat="server" ControlToValidate="txtCustPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
    &nbsp;or
        <asp:HyperLink ID="hlSignUp" runat="server" NavigateUrl="~/Register.aspx">Sign Up</asp:HyperLink>
    </form>
</body>
</html>
