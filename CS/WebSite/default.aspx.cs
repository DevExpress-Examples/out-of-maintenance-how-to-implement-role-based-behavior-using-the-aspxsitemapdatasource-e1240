using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxSiteMapControl;

public partial class CustomRoles : System.Web.UI.Page {

    public class MySiteMapProvider : UnboundSiteMapProvider {
        public override bool IsAccessibleToUser(HttpContext context, SiteMapNode node) {
            return IsRolesAccessibleToCurrentUser(node.Roles);
        }
    }

    public static bool IsRolesAccessibleToCurrentUser(IList roles) {
        // TODO: Your custom logic here
        if(roles.Contains("admin") && !IsAdmin())
            return false;
        return true;
    }
    protected static bool IsAdmin() {
        // TODO: Your custom logic here
        return HttpContext.Current.Request.Cookies["admin_key"] != null; 
    }
    protected void LoginAsAdmin() {
        // TODO: Your custom logic here
        HttpCookie cookie = new HttpCookie("admin_key");
        cookie.Expires = DateTime.Now.AddDays(1);
        Response.Cookies.Add(cookie);
        Response.Redirect(Request.Url.PathAndQuery, true);
    }
    protected void Logout() {
        // TODO: Your custom logic here
        HttpCookie cookie = new HttpCookie("admin_key");
        cookie.Expires = DateTime.Now.AddDays(-1);
        Response.Cookies.Add(cookie);
        Response.Redirect(Request.Url.PathAndQuery, true);
    }

    protected void Page_Load(object sender, EventArgs e) {
        MySiteMapProvider provider = new MySiteMapProvider();
        provider.SiteMapFileName = "~/web1.sitemap";
        provider.EnableRoles = true;
        ASPxSiteMapDataSource1.Provider = provider;

        if(IsAdmin())
            btLogin.Text = "Logout [Admin]";
        else
            btLogin.Text = "Login as Admin";
    }
    protected void btLogin_Click(object sender, EventArgs e) {
        if(IsAdmin()) 
            Logout();
        else 
            LoginAsAdmin();
        
    }
}

