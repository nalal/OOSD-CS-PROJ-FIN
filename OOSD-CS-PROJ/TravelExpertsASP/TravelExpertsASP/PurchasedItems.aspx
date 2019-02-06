<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PurchasedItems.aspx.cs" Inherits="TravelExpertsASP.PurchasedProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <link href="Styles/bootstrapLux.css" rel="stylesheet" />
     <link href="Styles/Main.css" rel="stylesheet" />
    <title>Purchased Items</title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="container">
                <img src="Images/l2.png" alt="logo" class="img-responsive" />
                <nav>
                    <ul>
                        <li><a href="http://localhost:61652/Login.aspx">Log In</a></li>
                        <li><a href="http://localhost:61652/Register.aspx">Register</a></li>
                    </ul>
                </nav>
            </div><!--end container-->
        </header>

       
         <div class="container" >
            <h1>
            Purchased Items<br /></h1>
            <br />
                <asp:DataList ID="dlAcctDetails" runat="server" BorderStyle="Double" BackColor="White" BorderColor="#336666" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="498px">
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="White" ForeColor="#333333" />
                    <ItemTemplate>
                        Destination:
                        <asp:Label Text='<%# Eval("Destination") %>' runat="server" id="DestinationLabel"/>
                        <br />
                        Description:
                        <asp:Label Text='<%# Eval("Description") %>' runat="server" id="DescriptionLabel"/>
                        <br />
                        ProdName:
                        <asp:Label Text='<%# Eval("ProdName") %>' runat="server" id="ProdNameLabel"/>
                        <br />
                        TripStart:
                        <asp:Label Text='<%# Eval("TripStart") %>' runat="server" id="TripStartLabel"/>
                        <br />
                        TripEnd:
                        <asp:Label Text='<%# Eval("TripEnd") %>' runat="server" id="TripEndLabel"/>
                        <br />
                        TravelerCount:
                        <asp:Label Text='<%# Eval("TravelerCount") %>' runat="server" id="TravelerCountLabel"/>
                        <br />
                        BookingId:
                        <asp:Label Text='<%# Eval("BookingId") %>' runat="server" id="BookingIdLabel"/>
                        <br />
                        BookingDate:
                        <asp:Label Text='<%# Eval("BookingDate") %>' runat="server" id="BookingDateLabel"/>
                        <br />
                        TTName:
                        <asp:Label Text='<%# Eval("TTName") %>' runat="server" id="TTNameLabel"/>
                        <br />
                        ClassName:
                        <asp:Label Text='<%# Eval("ClassName") %>' runat="server" id="ClassNameLabel"/>
                        <br />
                        BasePrice:
                         <asp:Label Text='<%# Eval("BasePrice", "{0:c}") %>' runat="server" id="BasePriceLabel"/>
                        <br />
                        FeeAmt:
                        <asp:Label Text='<%# Eval("FeeAmt", "{0:c}") %>' runat="server" id="FeeAmtLabel"/>
                        <br />
                        TotalCost:
                        <asp:Label Text='<%# Eval("TotalCost", "{0:c}") %>' runat="server" id="TotalCostLabel"/>
                        <br />
                        <br />
                        <br />
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                </asp:DataList>
        </div><!--end container-->
            
    </form>
</body>
</html>
