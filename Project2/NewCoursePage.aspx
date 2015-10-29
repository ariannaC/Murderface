<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCoursePage.aspx.cs" Inherits="Project2.NewCoursePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(Images/Flowers-Wallpaper-07.jpg); background-size:cover; background-repeat:no-repeat"><form id="form1" runat="server">
    <h1 style="text-align:center; color:black; font-weight:bold"> Add a New Course to the System </h1>
        <div style="color:black; font-weight:bold">
      CRN   <asp:TextBox ID="txtCRN" runat="server"></asp:TextBox>
            <br />
            <br />
           Title <asp:TextBox Style="border-bottom-color:darkred" ID="txtTitle" runat="server"></asp:TextBox>
            <br />
            <br />
          Department   <asp:DropDownList ID ="ddDepartment" runat="server"></asp:DropDownList>
             <br />
            <br />
          Credit Hours  <asp:DropDownList ID ="ddCreditHours" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
             <br />
            <br />
          Semester  <asp:DropDownList ID ="ddSemester" runat="server">
                <asp:ListItem>Spring</asp:ListItem>
                <asp:ListItem>Fall</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Day Code  <asp:DropDownList ID ="ddDayCode" runat="server">
                <asp:ListItem>TR</asp:ListItem>
                <asp:ListItem>MWF</asp:ListItem>
                <asp:ListItem>MW</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
             Time Period  <asp:DropDownList ID ="ddTimeCode" runat="server">
                <asp:ListItem>8-850am</asp:ListItem>
                <asp:ListItem>9-10:20am</asp:ListItem>
                <asp:ListItem>10:30-11:50am</asp:ListItem>
                  <asp:ListItem>12-1:20pm</asp:ListItem>
                 <asp:ListItem>1:30-2:50pm</asp:ListItem>
                 <asp:ListItem>3-4:20pm</asp:ListItem>
                 <asp:ListItem>5-5:50pm</asp:ListItem>
                 <asp:ListItem>5:30-8pm</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
           Section Number <asp:TextBox ID="txtSectionNum" runat="server"></asp:TextBox>
            <br />
            <br />
         Maximum Seats Available   <asp:TextBox Style="border-bottom-color:darkred" ID="txtMaxSeats" runat="server"></asp:TextBox>
             <br />
            <br />
         Professor   <asp:TextBox Style="border-bottom-color:darkred" ID="txtProfessor" runat="server"></asp:TextBox>           
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" /> <asp:Button ID="btnSubmit" runat="server" Text="Sumbit" OnClick="btnSubmit_Click" />
        </p>
    </form>
</body>
</html>
