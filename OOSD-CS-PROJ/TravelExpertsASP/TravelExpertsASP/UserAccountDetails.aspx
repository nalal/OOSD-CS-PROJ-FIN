<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserAccountDetails.aspx.cs" Inherits="TravelExpertsASP.UserAccountDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblLoginUserName" runat="server"></asp:Label>
&nbsp;<br />
        <br />
        <asp:Label ID="lblAccountDetails" runat="server" Text="Account Details"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" CausesValidation="False" OnClick="btnUpdate_Click1" Text="Update" />
        <asp:Button ID="btnSaveUpd" runat="server" OnClick="btnSaveUpd_Click" Text="Save" />
            <br />
            <br />
            <asp:Label ID="lblCustFirstName" runat="server" Text="First Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustFirstName" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustFirstName" runat="server" ErrorMessage="First name is required" ControlToValidate="txtCustFirstName" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustLastName" runat="server" Text="Last Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustLastName" runat="server" AutoPostBack="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustLastName" runat="server" ErrorMessage="Last name is required" ControlToValidate="txtCustLastName" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustAddress" runat="server" Text="Address:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustAddress" runat="server" AutoPostBack="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustAddress" runat="server" ControlToValidate="txtCustLastName" ErrorMessage="Address is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustCity" runat="server" Text="City:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustCity" runat="server" AutoPostBack="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustCity" runat="server" ControlToValidate="txtCustCity" ErrorMessage="City is required" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblCustProv" runat="server" Text="Province:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlCustProv" runat="server"  AppendDataBoundItems = "true" AutoPostBack="False">
                <asp:ListItem Selected = "True" Text = "" Value = ""></asp:ListItem>
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
            <asp:RequiredFieldValidator ID="rfvCustProv" runat="server" ControlToValidate="ddlCustProv" ErrorMessage="Province is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustPostal" runat="server" Text="Postal Code:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustPostal" runat="server" AutoPostBack="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustPostal" runat="server" ErrorMessage="Postal Code is required"  ForeColor="Red" ControlToValidate="txtCustPostal"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revCustPostal" runat="server" ControlToValidate="txtCustPostal" ErrorMessage="Invalid postal code format" ValidationExpression="^[A-Y]{1}[0-9]{1}[A-Z]{1}[ ]?[0-9]{1}[A-Z]{1}[0-9]{1}$" ForeColor="Red" Display="Dynamic"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustCountry" runat="server" Text="Country:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlCustCountry" AppendDataBoundItems = "true" runat="server">
                <asp:ListItem Selected = "True" Text = "" Value = ""></asp:ListItem>
                <asp:ListItem>CAN</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfvCustCountry" runat="server" ErrorMessage="Country is required" ControlToValidate="ddlCustCountry" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustHomePhone" runat="server" Text="Home Phone:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustHomePhone" runat="server" AutoPostBack="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustHomePhone" runat="server" ControlToValidate="txtCustHomePhone" ErrorMessage="Home phone number is required"  ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revCustHomePhone" runat="server" ControlToValidate="txtCustHomePhone" ErrorMessage="Invalid phone number format" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustBusPhone" runat="server" Text="Business Phone:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustBusPhone" runat="server" AutoPostBack="False"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCustBusPhone" runat="server" ControlToValidate="txtCustBusPhone" ErrorMessage="Invalid phone number format" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustEmail" runat="server" AutoPostBack="False" Width="120px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revCustEmail" runat="server" ControlToValidate="txtCustEmail" ErrorMessage="Invalid email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"  ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustUserName" runat="server" Text="User Name:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustUserName" runat="server" AutoPostBack="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustUserName" runat="server" ControlToValidate="txtCustUserName" ErrorMessage="User Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustPassword" runat="server" Text="Password: "></asp:Label>
&nbsp;<asp:TextBox ID="txtCustPassword" runat="server" AutoPostBack="False" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCustPassword" runat="server" ErrorMessage="Password is required" ControlToValidate="txtCustPassword" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Password must contain one upper case character, lower case character, number, and special character. It must be between 8-15 characters long." ForeColor="Red" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&amp;])[A-Za-z\d@$!%*?&amp;]{8,}$" ControlToValidate="txtCustPassword"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="lblCustRePassword" runat="server" Text="Re-enter Password: "></asp:Label>
&nbsp;<asp:TextBox ID="txtCustRePassword" runat="server" AutoPostBack="False" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="cvPasswords" runat="server" ControlToCompare="txtCustPassword" ControlToValidate="txtCustRePassword" ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>
            &nbsp;&nbsp;
            <br />
            <br />
        <div>
        </div>
    </form>
</body>
</html>
