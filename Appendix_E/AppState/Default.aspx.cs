using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void CleanAppData()
    {
        // Remove a single item via string name.
        Application.Remove("SomeItemIDontNeed");

        // Destroy all application data!
        Application.RemoveAll();
    }

    protected void btnShowAppVariables_Click(object sender, EventArgs e)
    {
        CarLotInfo appVars = ((CarLotInfo)Application["CarSiteInfo"]);
        string appState = $"<li>Car on sale: {appVars.CurrentCarOnSale}</li>";
        appState += $"<li>Most popular color: {appVars.MostPopularColorOnLot}</li>";
        appState += $"<li>Big shot SalesPerson: {appVars.SalesPersonOfTheMonth}</li>";
        lblAppVariables.Text = appState;
    }

    protected void btnSetNewSP_Click(object sender, EventArgs e)
    {
        // Set the new Salesperson.
        ((CarLotInfo)Application["CarSiteInfo"]).SalesPersonOfTheMonth
             = txtNewSP.Text;
    }
}