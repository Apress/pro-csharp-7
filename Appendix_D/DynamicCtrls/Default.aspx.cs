using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, System.EventArgs e)
    {
        ListControlsInPanel();
    }
    private void ListControlsInPanel()
    {
        var theInfo = "";
        theInfo = $"<b>Does the panel have controls? {myPanel.HasControls()} </b><br/>";

        // Get all controls in the panel.
        foreach (Control c in myPanel.Controls)
        {
            if (!object.ReferenceEquals(c.GetType(),
              typeof(System.Web.UI.LiteralControl)))
            {
                theInfo += "***************************<br/>";
                theInfo += $"Control Name? {c} <br/>";
                theInfo += $"ID? {c.ID} <br>";
                theInfo += $"Control Visible? {c.Visible} <br/>";
                theInfo += $"ViewState? {c.EnableViewState} <br/>";
            }
        }
        lblControlInfo.Text = theInfo;
    }

    protected void btnAddWidgets_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < 3; i++)
        {
            // Assign an ID so we can get
            // the text value out later
            // using the incoming form data.
            TextBox t = new TextBox {ID = $"newTextBox{i}"};
            myPanel.Controls.Add(t);
            ListControlsInPanel();
        }
    }

    protected void btnClearPanel_Click(object sender, EventArgs e)
    {
        // Clear all content from the panel, then re-list items.
        myPanel.Controls.Clear();
        ListControlsInPanel();
    }

    protected void btnGetTextData_Click(object sender, EventArgs e)
    {
        // Get teach text box by name.
        string lableData = $"<li>{Request.Form.Get("newTextBox0")}</li><br/>";
        lableData += $"<li>{Request.Form.Get("newTextBox1")}</li><br/>";
        lableData += $"<li>{Request.Form.Get("newTextBox2")}</li><br/>";
        lblTextBoxData.Text = lableData;
    }
}