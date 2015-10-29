<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BillingPage.aspx.cs" Inherits="Project2.BillingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(http://www.thegamescabin.com/wp-content/uploads/2015/01/driveclub-rainbow.jpg); background-size:cover; background-repeat:no-repeat">
    <form id="form1" runat="server">
    <div>
    <h1 style="text-align:center; color:darkmagenta; font-weight:bold"> Select a Student ID to View the Bill </h1>
    </div>
        <div style="text-align:left">
        <asp:DropDownList ID="ddStudentSelect" runat="server" OnSelectedIndexChanged="ddStudentSelect_SelectedIndexChanged">
        </asp:DropDownList>
            </div>
        <br />
        <br />

        <asp:Button ID="btnHome" runat="server" Text="Home" BackColor="ghostwhite" ForeColor="DarkMagenta" Font-Bold="true" Font-Size="Medium" OnClick="btnHome_Click" />
   <br />
        <br />
        <asp:Button ID="btnViewBill" runat="server" Text="View Bill" BackColor="GhostWhite" ForeColor="DarkMagenta" Font-Bold="true" Font-Size="Medium" OnClick="btnViewBill_Click" />
        
            <asp:GridView ID="gvBill" runat="server" style="z-index: 1; left: 594px; top: 60px; position: absolute; height: 133px; width: 187px; background-color:lightgray; color:darkmagenta" ShowFooter="True">
            </asp:GridView>
        
         </form>
</body>
</html>
