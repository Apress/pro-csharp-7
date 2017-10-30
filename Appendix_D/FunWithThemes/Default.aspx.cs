using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

partial class _Default : System.Web.UI.Page
{

  protected void btnNoTheme_Click(object sender, System.EventArgs e)
  {
    // Empty strings result in no theme being applied.
    Session["UserTheme"] = "";
    // Trigger the PreInit event again.
    Server.Transfer(Request.FilePath);
  }

  protected void btnGreenTheme_Click(object sender, System.EventArgs e)
  {
    Session["UserTheme"] = "BasicGreen";
    // Trigger the PreInit event again.
    Server.Transfer(Request.FilePath);
  }

  protected void btnOrangeTheme_Click(object sender, System.EventArgs e)
  {
    Session["UserTheme"] = "CrazyOrange";
    // Trigger the PreInit event again.
    Server.Transfer(Request.FilePath);
  }

  protected void Page_PreInit(object sender, System.EventArgs e)
  {
    try
    {
      Theme = Session["UserTheme"].ToString();
    }
    catch
    {
      // Empty strings result in no theme being applied.
      Theme = "";
    }
  }
}
