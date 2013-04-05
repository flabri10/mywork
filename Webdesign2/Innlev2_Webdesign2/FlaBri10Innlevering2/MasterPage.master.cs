using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SjekkSessions()
    {
        if (Session["BrukerSession"] != null)
        {
            int innloggetBruker = ((int[])Session["BrukerSession"])[2];
        }
        else
        {
            LoggUt();
            Response.Redirect("Logginn.aspx");
        }
    }

    protected void LoggUt()
    {
        if(Session["BrukerSession"] != null)
        {
            Session.Remove("BrukerSession");
            Response.Redirect("Forside.aspx");
        }
    }
}
