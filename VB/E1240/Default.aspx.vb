Imports DevExpress.Web
Imports System
Imports System.Collections
Imports System.Web

Namespace E1240
	Partial Public Class [Default]
		Inherits System.Web.UI.Page

		Public Class MySiteMapProvider
			Inherits UnboundSiteMapProvider

			Public Overrides Function IsAccessibleToUser(ByVal context As HttpContext, ByVal node As SiteMapNode) As Boolean
				Return IsRolesAccessibleToCurrentUser(node.Roles)
			End Function
		End Class

		Public Shared Function IsRolesAccessibleToCurrentUser(ByVal roles As IList) As Boolean
			' TODO: Your custom logic here
			If roles.Contains("admin") AndAlso Not IsAdmin() Then
				Return False
			End If
			Return True
		End Function
		Protected Shared Function IsAdmin() As Boolean
			' TODO: Your custom logic here
			Return HttpContext.Current.Request.Cookies("admin_key") IsNot Nothing
		End Function
		Protected Sub LoginAsAdmin()
			' TODO: Your custom logic here
			Dim cookie As New HttpCookie("admin_key")
			cookie.Expires = Date.Now.AddDays(1)
			Response.Cookies.Add(cookie)
			Response.Redirect(Request.Url.PathAndQuery, True)
		End Sub
		Protected Sub Logout()
			' TODO: Your custom logic here
			Dim cookie As New HttpCookie("admin_key")
			cookie.Expires = Date.Now.AddDays(-1)
			Response.Cookies.Add(cookie)
			Response.Redirect(Request.Url.PathAndQuery, True)
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim provider As New MySiteMapProvider()
			provider.SiteMapFileName = "~/web1.sitemap"
			provider.EnableRoles = True
			ASPxSiteMapDataSource1.Provider = provider

			If IsAdmin() Then
				btLogin.Text = "Logout [Admin]"
			Else
				btLogin.Text = "Login as Admin"
			End If
		End Sub

		Protected Sub btLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
			If IsAdmin() Then
				Logout()
			Else
				LoginAsAdmin()
			End If
		End Sub
	End Class
End Namespace