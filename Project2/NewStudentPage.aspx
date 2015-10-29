<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewStudentPage.aspx.cs" Inherits="Project2.NewStudentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-size:cover; background-image:url(Images/sunflowers-wallpaper.jpg); background-repeat:no-repeat">
    <form id="form1" runat="server">
    <div>
    <h1 style="color:white; outline-color:darkgoldenrod; font-weight:bold; font-family:'Bodoni MT'; text-align:center">Add a New Student to the System</h1>
    </div>
        <div style="text-align:center">
            <asp:Label ID="lblNewStudent" Text="Name" runat="server" style="color:ghostwhite; font-weight:bold; font-size:x-large"></asp:Label> <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 387px; top: 72px; position: absolute"></asp:TextBox>
            <br />
            <br />
             <asp:Label ID="Label1" Text="Student ID" runat="server" style="color:ghostwhite; font-size:x-large; font-weight:bold;"></asp:Label> <asp:TextBox ID="TxtID" runat="server" style="z-index: 1; left: 388px; top: 124px; position: absolute; right: 685px;"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" Text="Add Student" runat="server" style="color:midnightblue; font-weight:bold; font-size:medium; z-index: 1; left: 853px; top: 190px; position: absolute;" OnClick="btnAdd_Click" /> <asp:Button ID="btnHome" Text="Home" runat="server" Style="color:midnightblue; font-weight:bold; font-size:medium; z-index: 1; top: 188px; position: absolute; left: 1010px;" OnClick="btnHome_Click" />
                 
        </div>
    </form>
</body>
</html>
