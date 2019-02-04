﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PurchasedItems.aspx.cs" Inherits="TravelExpertsASP.PurchasedProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Purchased Items<br />
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
                    <asp:Label Text='<%# Eval("BasePrice") %>' runat="server" id="BasePriceLabel"/>
                    <br />
                    FeeAmt:
                    <asp:Label Text='<%# Eval("FeeAmt") %>' runat="server" id="FeeAmtLabel"/>
                    <br />
                    TotalCost:
                    <asp:Label Text='<%# Eval("TotalCost") %>' runat="server" id="TotalCostLabel"/>
                    <br />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>