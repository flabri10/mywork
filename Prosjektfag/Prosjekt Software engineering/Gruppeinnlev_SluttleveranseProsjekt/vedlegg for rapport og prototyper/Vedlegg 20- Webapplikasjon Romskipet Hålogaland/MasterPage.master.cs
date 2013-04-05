using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] != null)
        {
            lbtnLoggInn.Text = "Du er logget inn som " + ((String[])Session["AdministratorSession"])[3] + " " + ((String[])Session["AdministratorSession"])[4] + " (Logg ut)";
        }

        if (Session["BrukerSession"] != null)
        {
            lbtnLoggInn.Text = "Du er logget inn som " + ((String[])Session["BrukerSession"])[3] + " " + ((String[])Session["BrukerSession"])[4] + " (Logg ut)";
        }
    }

    protected void SjekkLoggInnStatus(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] != null || Session["BrukerSession"] != null)
        {
            LoggUt();
            Response.Redirect(Request.Url.ToString());
        }

        else
        {
            Response.Redirect("LoggInn.aspx");
        }
    }

    protected void LoggUt()
    {
        Session.Remove("Handlekurv");
        Session.Remove("BrukerSession");
        Session.Remove("AdministratorSession");
        Response.Redirect("Forside.aspx");
    }
}