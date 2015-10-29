<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountsPage.aspx.cs" Inherits="Project3.AccountsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        
        <asp:Button ID="btnAddNew" runat="server" Text="Add Credit Card" OnClick="btnAddNew_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text=" Update Credit Card" />
        <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
        <asp:TextBox ID="txtCCNum" placeholder="Enter Credit Card Number" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtCVV" placeholder="Enter CVV Code" runat="server"></asp:TextBox>
       
        <asp:TextBox ID="txtLimit" placeholder="Enter Credit Limit" runat="server"></asp:TextBox>
        
        <asp:TextBox ID="txtAccBal" placeholder="Enter Account Balance" runat="server"></asp:TextBox>
         <asp:TextBox ID="txtFName" placeholder="Enter First Name on Card" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLName" placeholder="Enter Last Name on Card" runat="server"></asp:TextBox>
        
    </form>
</body>
</html>
