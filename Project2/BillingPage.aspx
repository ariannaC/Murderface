<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BillingPage.aspx.cs" Inherits="Project2.BillingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align:center; color:darkgoldenrod; font-weight:bold"> Select a Student ID to View the Bill </h1>
    </div>
        <div style="text-align:center">
        <asp:DropDownList ID="ddStudentSelect" runat="server">
        </asp:DropDownList>
            </div>
    </form>
</body>
</html>
