<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewStudentPage.aspx.cs" Inherits="Project2.NewStudentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="color:darkgoldenrod; font-weight:bold; font-family:'Bodoni MT'; text-align:center">Add a New Student to the System</h1>
    </div>
        <div style="text-align:center">
            <asp:Label ID="lblNewStudent" Text="Name" runat="server" style="color:darkgoldenrod; font-weight:bold;"></asp:Label> <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 811px; top: 72px; position: absolute"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label1" Text="Student ID" runat="server" style="color:darkgoldenrod; font-weight:bold;"></asp:Label> <asp:TextBox ID="TxtID" runat="server" style="z-index: 1; left: 811px; top: 105px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" Text="Add Student" runat="server" style="color:darkred; font-weight:bold; font-size:medium; z-index: 1; left: 726px; top: 148px; position: absolute;" OnClick="btnAdd_Click" /> <asp:Button ID="btnHome" Text="Home" runat="server" Style="color:darkred; font-weight:bold; font-size:medium; z-index: 1; top: 148px; position: absolute; left: 900px;" OnClick="btnHome_Click" />
                 
        </div>
    </form>
</body>
</html>
