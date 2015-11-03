﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionsPage.aspx.cs" Inherits="Project3.TransactionsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <h1 style="text-align:center">Process a New Transaction</h1>
    <h4>Update Billing Information for the card number entered. (cannot change name on card or card number)</h4>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtFName" placeholder="Enter First Name" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLName" placeholder="Enter Last Name" runat="server"></asp:TextBox>
       
        <asp:TextBox ID="txtCCNum" placeholder="Enter Credit Card Number" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtCVV" placeholder="Enter CVV Code" runat="server"></asp:TextBox>
       
        <asp:TextBox ID="txtAddress" placeholder="Enter Address" runat="server"></asp:TextBox>
        
        <asp:TextBox ID="txtCity" placeholder="Enter City" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextState" placeholder="Enter State" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtZip" placeholder="Zip Code" runat="server"></asp:TextBox>
        <asp:TextBox ID="TxtTransAmnt" placeholder="Enter Transaction Amount" runat="server"></asp:TextBox>
          <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
          <asp:Button ID="btnProcessTransaction" runat="server" Text="Process Transaction" OnClick="btnAddNew_Click" />
        <div> 
          <asp:Label runat="server" ID="txtErrors"></asp:Label>
        </div>
    </form>
 
</body>
</html>
