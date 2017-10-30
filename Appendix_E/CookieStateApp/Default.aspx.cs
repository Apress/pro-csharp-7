using System;
using System.Web;
using System.Web.UI;

public partial class _Default : Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCookie_Click(object sender, EventArgs e)
    {
        // Make a new (temp) cookie.
        HttpCookie theCookie = new HttpCookie(txtCookieName.Text,txtCookieValue.Text)
            { Expires = DateTime.Parse("12/31/2015")};
        Response.Cookies.Add(theCookie);
    }

    protected void btnShowCookie_Click(object sender, EventArgs e)
    {
        string cookieData = "";
        foreach (string s in Request.Cookies)
        {
            cookieData += $"<li><b>Name</b>: {s}, <b>Value</b>: {Request.Cookies[s]?.Value}</li>";
        }
        lblCookieData.Text = cookieData;
    }
}