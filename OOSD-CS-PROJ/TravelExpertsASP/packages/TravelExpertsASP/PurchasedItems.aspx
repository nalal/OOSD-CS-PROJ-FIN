<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PurchasedItems.aspx.cs" Inherits="TravelExpertsASP.PurchasedProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styles/bootstrapLux.css" rel="stylesheet" />
    <link href="Styles/nav.css" rel="stylesheet" />
     <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
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
                        <li><a href="http://localhost:61652/UserAccountDetails.aspx">Account Details</a></li>
                        <li><a href="http://localhost:61652/PurchasedItems.aspx">Purchased Items</a></li>
                        <li><a href="http://localhost:61652/Login.aspx">Log Out</a></li>

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
            <h5 class="label">
            Purchased Items<br /></h5>
            <br />
            <asp:DataList ID="dlAcctDetails" runat="server" BorderStyle="Dotted">
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
            </asp:DataList>
        </div>
    </form>
    <br />
    <footer class="container-fluid text-center footerDiv">
        <p>This page copyrighted &copy; by Travel Experts</p>
    </footer>
</body>
</html>
