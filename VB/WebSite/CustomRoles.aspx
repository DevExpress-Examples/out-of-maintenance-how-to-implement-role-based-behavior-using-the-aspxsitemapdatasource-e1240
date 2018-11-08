<%@ Page Language="vb" AutoEventWireup="true" CodeFile="CustomRoles.aspx.vb" Inherits="CustomRoles" %>

<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dxm" %>

<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxUploadControl"
	TagPrefix="dxuc" %>

<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxSiteMapControl"
	TagPrefix="dxsm" %>

<%@ Register Assembly="DevExpress.Web.v13.1" Namespace="DevExpress.Web.ASPxEditors"
	TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>How to implement role-based behavior using the ASPxSiteMapDataSource</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <dxe:ASPxButton ID="btLogin" runat="server" Text="Login as Admin" OnClick="btLogin_Click">
        </dxe:ASPxButton>
        <dxm:ASPxMenu id="ASPxMenu1" runat="server" borderbetweenitemandsubmenu="HideRootOnly"
            datasourceid="ASPxSiteMapDataSource1" showpopoutimages="True"></dxm:ASPxMenu>
        <dxsm:ASPxSiteMapControl  id="ASPxSiteMapControl1" runat="server" datasourceid="ASPxSiteMapDataSource1" EnableViewState="False">
        </dxsm:ASPxSiteMapControl>
     </div>
        <dxsm:ASPxSiteMapDataSource id="ASPxSiteMapDataSource1" runat="server" EnableViewState="False"></dxsm:ASPxSiteMapDataSource>
        <dxe:ASPxButton ID="ASPxButton1" runat="server" Text="PostBack">
        </dxe:ASPxButton>
    </form>
</body>
</html>
