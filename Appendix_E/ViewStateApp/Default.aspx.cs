using System;
using System.Web.UI;

public partial class _Default : Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Fill ListBox dynamically!
            myListBox.Items.Add("Item One");
            myListBox.Items.Add("Item Two");
            myListBox.Items.Add("Item Three");
            myListBox.Items.Add("Item Four");
        }
    }
    protected void btnPostback_Click(object sender, EventArgs e)
    {
        // No-op. This is just here to allow a post back.
    }
    protected void btnAddToVS_Click(object sender, EventArgs e)
    {
        ViewState["CustomViewStateItem"] = "Some user data";
        lblVSValue.Text = (string)ViewState["CustomViewStateItem"];
    }
}