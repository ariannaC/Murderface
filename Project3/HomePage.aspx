<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project3.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnAddCard" runat="server" OnClick="btnAddCard_Click" Text="Add Credit Card" />
        <asp:Button ID="btnTransaction" runat="server" OnClick="btnTransaction_Click" Text="New Transaction " />
    
    </div>
    </form>
</body>
</html>
