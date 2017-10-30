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

public partial class _Default : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    GetUserAddress();
  }
  protected void btnSubmit_Click(object sender, EventArgs e)
  {
    // Database writes happening here!
    Profile.AddressInfo.City = txtCity.Text;
    Profile.AddressInfo.Street = txtStreetAddress.Text;
    Profile.AddressInfo.State = txtState.Text;

    // Get settings from database.
    GetUserAddress();
  }

  private void GetUserAddress()
  {
    // Database reads happening here!
    lblUserData.Text =
        $"You live here: {Profile.AddressInfo.Street}, {Profile.AddressInfo.City}, " + 
        $"{Profile.AddressInfo.State}";
  }
}
