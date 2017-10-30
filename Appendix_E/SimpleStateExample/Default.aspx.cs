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
    // State data?
    // private string userFavoriteCar;  

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSetCar_Click(object sender, EventArgs e)
    {
        // Store fav car in member variable.
        // userFavoriteCar = txtFavCar.Text;
        Session["UserFavCar"] = txtFavCar.Text;
    }
    protected void btnGetCar_Click(object sender, EventArgs e)
    {
        // Show value of member variable.
        // lblFavCar.Text = userFavoriteCar;
        lblFavCar.Text = (string)Session["UserFavCar"];
    }
}