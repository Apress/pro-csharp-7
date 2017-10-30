using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.IO.File;

public partial class _Default : System.Web.UI.Page
{
    public _Default()
    {
        // Explicitly hook into the Load and Unload events.
        Load += Page_Load;
        Unload += Page_Unload;
        Error += _Default_Error;
    }

    void _Default_Error(object sender, EventArgs e)
    {
        Response.Clear();
        Response.Write("I am sorry...I can't find a required file.<br>");
        Response.Write($"The error was: <b>{Server.GetLastError().Message}</b>");
        Server.ClearError();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("Load event fired!");
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        // No longer possible to emit data to the HTTP
        // response, so we will write to a local file.
        WriteAllText(@"C:\MyLog.txt", "Page unloading!");
    }

    protected void btnPostback_Click(object sender, EventArgs e)
    {
        // Nothing happens here, this is just to ensure a 
        // postback to the page. 
    }
    protected void btnTriggerError_Click(object sender, EventArgs e)
    {
        ReadAllText(@"C:\IDontExist.txt");
    }
}