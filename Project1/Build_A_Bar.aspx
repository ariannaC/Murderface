<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Build_A_Bar.aspx.cs" Inherits="Project1.Build_A_Bar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DethCars</title>
    <style type="text/css">
        #frmBAB {
            height: 2px;
        }
      
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body style="background-color:beige">
    <form id="form1" runat="server">
    <h1 style="color:black; text-align:center; font-family:Leelawadee" class="auto-style1">
        <asp:DropDownList ID="ddlMake" Font-Bold="true" ForeColor="DarkRed" runat="server" style="z-index: 1; left: 520px; top: 131px; position: absolute; height: 22px; right: 684px;" AutoPostBack="True" OnSelectedIndexChanged="ddlMake_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlModel" Font-Bold="true" ForeColor="DarkRed" runat="server" style="z-index: 1; left: 729px; top: 130px; position: absolute">
        </asp:DropDownList>
        Mordhaus Mega Motors</h1>
   
    <h3 style="text-align:left; color:black; margin-left: 40px;">&nbsp;&nbsp; Customer Information:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Car Selection:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Package Selection:</h3>
    
    
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 64px; top: 126px; color:darkred; position: absolute; height: 23px; width: 77px; font-size: large; font-weight: 700;" Text="Name"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" style="z-index: 1; left: 63px; color:darkred; top: 169px; position: absolute; font-size: large; right: 1083px; font-weight: 700;"></asp:Label>
        <asp:Label ID="lblAddress1" runat="server" Text="Address Line1" style="z-index: 1; left: 63px; top: 207px; position: absolute; color:darkred; font-weight: 700; font-size: large; right: 1098px;"></asp:Label>
        <asp:Label ID="lblAddress2" runat="server" style="z-index: 1; left: 62px; color:darkred; top: 246px; position: absolute; font-weight: 700; font-size: large" Text="Address Line2"></asp:Label>
        <asp:Label ID="lblCity" runat="server" Text="City " style="font-weight: 700; color:darkred; font-size: large; z-index: 1; left: 64px; top: 289px; position: absolute; right: 1183px;"></asp:Label>
        <asp:Label ID="lblState" runat="server" Text="State" style="font-size: large; color:darkred; font-weight: 700; z-index: 1; left: 64px; top: 334px; position: absolute; right: 1178px;"></asp:Label>
        <asp:Label ID="lblZip" runat="server" style="z-index: 1; left: 63px; top: 370px; position: absolute; color:darkred; font-size: large; font-weight: 700; height: 20px;" Text="Zip"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 222px; top: 130px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 224px; top: 168px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress1" runat="server" style="z-index: 1; left: 224px; top: 207px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress2" runat="server" style="z-index: 1; left: 224px; top: 245px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 224px; top: 288px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtState" runat="server" style="z-index: 1; left: 225px; top: 334px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtZip" runat="server" style="z-index: 1; left: 225px; top: 374px; position: absolute"></asp:TextBox>
        <asp:RadioButton ID="rdbBuy" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 61px; top: 568px; position: absolute" Text="Buy" ForeColor="DarkRed" />
    <asp:RadioButton ID="rdbLease" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 201px; top: 572px; position: absolute" Text="Lease" ForeColor="DarkRed" />
         <asp:GridView ID="gvPackages" runat="server" style="z-index: 1; text-align:center; left: 921px; top: 120px; position: absolute; height: 133px; width: 187px" OnSelectedIndexChanged="gvPackages_SelectedIndexChanged" OnRowEditing="gvPackages_RowEditing" OnRowCancelingEdit="gvPackages_RowCancelingEdit">
             <Columns>
                 <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Add Package" ShowHeader="True" Text="Add" />
             </Columns>
        </asp:GridView>
         <asp:Label ID="lblColorSelect" runat="server" Text="Select the color of your car :)" style="z-index: 1; left: 521px; top: 173px; position: absolute; font-weight: 700; font-size: large"></asp:Label>
        <asp:DropDownList ID="ddlColor" Font-Bold="true" ForeColor="DarkRed" runat="server" style="z-index: 1; left: 521px; top: 221px; position: absolute">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Black</asp:ListItem>
            <asp:ListItem>Forest Green</asp:ListItem>
            <asp:ListItem>Hot Pink</asp:ListItem>
            <asp:ListItem>Blue</asp:ListItem>
            <asp:ListItem>Silver</asp:ListItem>
        </asp:DropDownList>
         <asp:RadioButton ID="rdbCall" Text="Call" Font-Bold="true" ForeColor="DarkRed" runat="server" style="z-index: 1; left: 62px; top: 480px; position: absolute" />
        <asp:RadioButton ID="rdbDealership" Text="Visit Dealership" Font-Bold="true" ForeColor="DarkRed" runat="server" style="z-index: 1; left: 196px; top: 481px; position: absolute" />
        <asp:Label ID="lblPaymentOpt" runat="server" style="z-index: 1; left: 62px; top: 526px; position: absolute" Font-Bold="true" ForeColor="Black" Text="Would you like to buy or lease your car?"></asp:Label>
         <asp:Label ID="lblFollowUpOpt" Font-Bold="True" runat="server" style="z-index: 1; left: 59px; top: 429px; position: absolute" Text="Would you like the dealership to call you or come in for followup information about your purchase?"></asp:Label>
         <asp:Button ID="btnConfirmOrder" Font-Bold="true" ForeColor="DarkRed" runat="server" style="z-index: 1; left: 39px; top: 627px; position: absolute" Text="Confirm and Display Order" OnClick="btnConfirmOrder_Click" />
         <asp:GridView ID="gvOutput" runat="server" style="z-index: 1; left: 505px; top: 519px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
         <asp:Button ID="Button1" Font-Bold="true" BackColor="HotPink" ForeColor="Black" runat="server" style="z-index: 1; left: 321px; top: 626px; position: absolute" Text="Start Over" OnClick="Button1_Click" />
        <asp:HiddenField ID="hfSelectedPackages" runat="server" />
         <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 816px; top: 484px; position: absolute; font-weight: 700" Text="Checkout Information"></asp:Label>
        <asp:Label ID="lblOutPhone" runat="server" style="z-index: 1; left: 820px; top: 549px; position: absolute; bottom: 89px"></asp:Label>
        <asp:Label ID="lblOutAddress" runat="server" style="z-index: 1; left: 819px; top: 577px; position: absolute"></asp:Label>
        <asp:Label ID="lblOutMake" runat="server" style="z-index: 1; left: 1065px; top: 523px; position: absolute"></asp:Label>
        <asp:Label ID="lblOutModel" runat="server" style="z-index: 1; left: 1064px; top: 550px; position: absolute"></asp:Label>
        <asp:Label ID="lblOtherOptions" runat="server" style="z-index: 1; left: 1064px; top: 575px; position: absolute"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 514px; top: 485px; position: absolute; font-weight: 700" Text="Final Package Selection:"></asp:Label>
         <p>
             &nbsp;</p>
        <asp:Label ID="lblOutName" runat="server" style="z-index: 1; left: 820px; top: 522px; position:absolute"></asp:Label>
         <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 505px; top: 779px; position: absolute" Text="Total Cost: "></asp:Label>
         </form>
    
    
     </body>
</html>
