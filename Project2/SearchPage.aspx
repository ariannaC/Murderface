<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="Project2.SearchPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(Images/flowers-hd-wallpaper-free-download-239.jpg); background-size:cover; background-repeat:no-repeat">
    <form id="form1" runat="server">
    <div style="text-align:center">
    <h1 style="text-align:center; color:black; font-weight:bold">Course Registration </h1>
    </div>
        <div>
        <asp:DropDownList ID="ddStudentSelect" runat="server">
        </asp:DropDownList>  
        </div>
        <div style="text-align:center">
        <asp:GridView style="position:absolute; top: 67px; left: 463px; color:darkred; background-color:ghostwhite" ID="gvCourses" runat="server">
            <Columns>
                <asp:TemplateField AccessibleHeaderText="Select" HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbSelectCourse" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </div>
        <br />
        <asp:Button ID="btnHome" runat="server" Text="Home" BackColor="ghostwhite" ForeColor="darkred" Font-Bold="true" Font-Size="Medium" OnClick="btnHome_Click" style="height: 29px" />
        <br />
        <br />
         <asp:Button ID="btnRegister" runat="server" Text="Register" BackColor="ghostwhite" ForeColor="darkred" Font-Bold="true" Font-Size="Medium" style="height: 29px" OnClick="btnRegister_Click" />
    </form>
</body>
</html>
