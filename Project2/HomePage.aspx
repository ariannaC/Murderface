<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Project2.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sunflwoer High Registration</title>
</head>
<body style="background-image:url(Images/sunflowers_wallpaper_858b5.jpg); background-size:cover; background-repeat:no-repeat">
     
    <form id="form1" runat="server">
    <h1 style="text-align:center; color:darkred; font-family:'Bodoni MT'; font-weight:bold; text-align:center">Welcome to the SunFlower High Course Registration System! </h1>
       <br />
        <asp:DropDownList ID="ddStudent" runat="server" style="z-index: 1; left: 317px; top: 100px; position: absolute" OnSelectedIndexChanged="ddStudent_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <asp:DropDownList ID="ddAdmin" runat="server" style="z-index: 1; left: 816px; top: 100px; position: absolute" AutoPostBack="True" OnSelectedIndexChanged="ddAdmin_SelectedIndexChanged">
        </asp:DropDownList>
        <br /> <br /> <br />
        
        
        
        
        <div style="text-align:center; width:100%">
            <asp:Button ID="btnNewStudent" runat="server" Text="Create Student" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center" OnClick="btnNewStudent_Click"/>
       <br />
        <br />
         <asp:Button ID="btnNewCourse" runat="server" Text="Create Course" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center" OnClick="btnCourse_Click"/>
<br />
           <br />

         <asp:Button ID="Button2" runat="server" Text="Course Registration" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center" OnClick="Button2_Click"/>
        <br />
           <br />

        <asp:Button ID="Button3" runat="server" Text="View Bill" BackColor="DarkRed" ForeColor="White" Font-Bold="true" Font-Size="Large" style="width:218px; text-align: center" OnClick="Button3_Click"/>
        </div>
               
        <asp:Label ID="lblAdmin" runat="server" style="background-color:ghostwhite; color:black; font-family:'Bodoni MT'; font-size:medium; font-weight:bold;z-index: 1; left: 812px; top: 66px; position: absolute" Text=" Administrator Login "></asp:Label>
             <asp:Label ID="lblStudent" runat="server" style="background-color:ghostwhite; color:black; font-family:'Bodoni MT'; font-size:medium; font-weight:bold;z-index: 1; left: 306px; top: 66px; position: absolute" Text=" Student Login "></asp:Label>  
    </form>
</body>
</html>
