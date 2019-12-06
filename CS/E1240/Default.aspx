<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E1240.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to implement role-based behavior using the ASPxSiteMapDataSource</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <dx:ASPxButton ID="btLogin" runat="server" Text="Login as Admin" OnClick="btLogin_Click">
            </dx:ASPxButton>
            <dx:ASPxMenu ID="ASPxMenu1" runat="server" BorderBetweenItemAndSubMenu="HideRootOnly"
                DataSourceID="ASPxSiteMapDataSource1" ShowPopOutImages="True">
            </dx:ASPxMenu>
            <dx:ASPxSiteMapControl ID="ASPxSiteMapControl1" runat="server" DataSourceID="ASPxSiteMapDataSource1" EnableViewState="False">
            </dx:ASPxSiteMapControl>
         </div>
        <dx:ASPxSiteMapDataSource ID="ASPxSiteMapDataSource1" runat="server" EnableViewState="False"></dx:ASPxSiteMapDataSource>
        <dx:ASPxButton ID="ASPxButton1" runat="server" Text="PostBack">
        </dx:ASPxButton>
    </form>
</body>
</html>
