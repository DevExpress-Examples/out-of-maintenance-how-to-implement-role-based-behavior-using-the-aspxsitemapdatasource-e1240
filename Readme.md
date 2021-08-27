<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128564619/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1240)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [default.aspx](./CS/WebSite/default.aspx)
* [default.aspx.cs](./CS/WebSite/default.aspx.cs)
* [web1.sitemap](./CS/WebSite/web1.sitemap)
<!-- default file list end -->
# How to implement role-based behavior using the ASPxSiteMapDataSource 
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1240/)**
<!-- run online end -->


<p>This example demonstrates how to implement role management at the level of the SiteMapProvider. This approach seems to be more straightforward than using a standard RoleProvider, and defining roles in the ASP.NET configuration.<br />
The web1.sitemap file contains nodes to be visualized by the ASPxMenu and ASPxSiteMap controls. Some nodes are defined to be available for administrators only (see nodes with "admin" roles). These nodes are not displayed for standard users.<br />
When logging in as an administrator, these nodes become visible within the ASPxMenu and ASPxSiteMap controls. <br />
A check of a node's availability for the current user's role is performed by the IsAccessibleToUser method derived from the UnboundSiteMapProvider.</p>

<br/>


