<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionsPage.aspx.cs" Inherits="Project3.TransactionsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
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
        <asp:Button ID="btnViewInfo" runat="server" Text="View Information" />
    </form>
</body>
</html>
