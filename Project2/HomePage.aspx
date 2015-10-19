<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project2.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sunnydale Registration</title>
</head>
<body>
     
    <form id="form1" runat="server">
    <h1 style="text-align:center; color:darkgoldenrod; font-family:'Bodoni MT'; font-weight:bold; text-align:center">Welcome to the Sunnydale High Course Registration System! </h1>
       <div style="text-align:center; width:100%">
         <asp:Button ID="btnNewStudent" runat="server" Text="Create Student" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center" OnClick="btnNewStudent_Click"/>
       <br />
           <br />
         <asp:Button ID="btnCourse" runat="server" Text="Create Course" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center" OnClick="btnCourse_Click"/>
       <br />
           <br />

         <asp:Button ID="Button2" runat="server" Text="Course Registration" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center"/>
        <br />
           <br />

        <asp:Button ID="Button3" runat="server" Text="View Bill" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center" OnClick="Button3_Click"/>
        </div>
               
    </form>
</body>
</html>
