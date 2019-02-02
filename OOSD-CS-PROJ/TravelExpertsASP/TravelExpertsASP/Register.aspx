<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TravelExpertsASP.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register
            <br />
            <br />
            <asp:Label ID="lblCustFirstName" runat="server" Text="First Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustFirstName" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First name is required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustLastName" runat="server" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustLastName" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last name is required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustAddress" runat="server" Text="Address:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustAddress" runat="server" AutoPostBack="True" OnTextChanged="txtCustAddress_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustCity" runat="server" Text="City:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustCity" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustProv" runat="server" Text="Province:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustProv" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustPostal" runat="server" Text="Postal Code:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustPostal" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustCountry" runat="server" Text="Country:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustCountry" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustHomePhone" runat="server" Text="Home Phone:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustHomePhone" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustBusPhone" runat="server" Text="Business Phone:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustBusPhone" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustEmail" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustUserName" runat="server" Text="User Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustUserName" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustPassword" runat="server" Text="Password: "></asp:Label>
&nbsp;<asp:TextBox ID="txtCustPassword" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustRePassword" runat="server" Text="Re-enter Password: "></asp:Label>
&nbsp;<asp:TextBox ID="txtCustRePassword" runat="server" AutoPostBack="True"></asp:TextBox>
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="btnCustRegister" runat="server" OnClick="btnCustRegister_Click" Text="Register" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
