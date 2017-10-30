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
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Set current user prefs.
        var cart = (UserShoppingCart)Session["UserShoppingCartInfo"];
        cart.DateOfPickUp = myCalendar.SelectedDate;
        cart.DesiredCar = txtCarMake.Text;
        cart.DesiredCarColor = txtCarColor.Text;
        cart.DownPayment = float.Parse(txtDownPayment.Text);
        cart.IsLeasing = chkIsLeasing.Checked;
        lblUserInfo.Text = cart.ToString();
        Session["UserShoppingCartInfo"] = cart;
    }
}