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
            <asp:RequiredFieldValidator ID="rfvCustFirstName" runat="server" ErrorMessage="First name is required" ControlToValidate="txtCustFirstName"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustLastName" runat="server" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustLastName" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustLastName" runat="server" ErrorMessage="Last name is required" ControlToValidate="txtCustLastName"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustAddress" runat="server" Text="Address:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustAddress" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustAddress" runat="server" ControlToValidate="txtCustLastName" ErrorMessage="Address is required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustCity" runat="server" Text="City:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustCity" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustCity" runat="server" ControlToValidate="txtCustCity" ErrorMessage="City is required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustProv" runat="server" Text="Province:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlCustProv" runat="server" AutoPostBack="True">
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
            <asp:RequiredFieldValidator ID="rfvCustProv" runat="server" ControlToValidate="ddlCustProv" ErrorMessage="Province is required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustPostal" runat="server" Text="Postal Code:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustPostal" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCustPostal" runat="server" ControlToValidate="txtCustPostal" ErrorMessage="Invalid postal code format" ValidationExpression="^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustCountry" runat="server" Text="Country:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlCustCountry" runat="server">
                <asp:ListItem>CAN</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvCustCountry" runat="server" ErrorMessage="A country must be selected"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustHomePhone" runat="server" Text="Home Phone:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustHomePhone" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCustHomePhone" runat="server" ControlToValidate="txtCustHomePhone" ErrorMessage="Invalid phone number format" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustBusPhone" runat="server" Text="Business Phone:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustBusPhone" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCustBusPhone" runat="server" ControlToValidate="txtCustBusPhone" ErrorMessage="Invalid phone number format" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustEmail" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCustEmail" runat="server" ControlToValidate="txtCustEmail" ErrorMessage="Invalid email format" ValidationExpression="^(?(&quot;)(&quot;.+?(?&lt;!\\)&quot;@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&amp;'\*\+/=\?\^`\{\}\|~\w])*)(?&lt;=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustUserName" runat="server" Text="User Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustUserName" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustUserName" runat="server" ControlToValidate="txtCustUserName" ErrorMessage="User Name is required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustPassword" runat="server" Text="Password: "></asp:Label>
&nbsp;<asp:TextBox ID="txtCustPassword" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustPassword" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustRePassword" runat="server" Text="Re-enter Password: "></asp:Label>
&nbsp;<asp:TextBox ID="txtCustRePassword" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:CompareValidator ID="cvPasswords" runat="server" ControlToCompare="txtCustPassword" ControlToValidate="txtCustRePassword" ErrorMessage="Passwords do not match"></asp:CompareValidator>
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
