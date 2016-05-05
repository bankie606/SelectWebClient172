<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Tracker</title>
    <link rel="stylesheet" href="css/StyleSheet.css"/>
</head>
<body class="mainbody">
    <form id="form1" runat="server">
    <div class="visualcenter">
    <h1>List of Venues</h1>
        <asp:GridView ID="GridViewVenues" runat="server"></asp:GridView>
    </div>
    <div class="visualcenter">
     <h1>List of Artists</h1>
         <asp:GridView ID="GridViewArtists" runat="server"></asp:GridView>
    </div>
     <div class="visualcenter">
     <h1>List of Shows</h1>
          <asp:GridView ID="GridViewShows" runat="server"></asp:GridView>
    </div>

        
    <div class="visualcenter">
        <h1>Select an Artist to See Where They Are Playing</h1>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Click Here" OnClick="Button1_Click" />
    </div>
    <div class="visualcenter">
        <h1>Select a Venue to See What's Going On</h1>
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        <asp:Button ID="Button2" runat="server" Text="Click Here" OnClick="Button2_Click" />
    </div>

    </form>
</body>
</html>
