using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    String statustekst;
    string brukernavn;
    string passord;

    protected void Page_Load(object sender, EventArgs e)
    {
        VisStatus();
    }

    protected void VisStatus()
    {
        LoggInnHandler nyLoggInnHandler = new LoggInnHandler();
        bool loggInnOk = nyLoggInnHandler.SjekkOmRiktigLoggInn(brukernavn, passord);

        String statusTekst;

        if (loggInnOk == true)
        {
            Brukernavn = brukernavn;
            statusTekst = "Du er logget inn. Velkommen " + Brukernavn + "!";
        }
        else
        {
            statusTekst = "Feil ved innlogging!";
            //Response.Redirect("logginn.aspx");
        }

        litLoggInnStatus.Text = statusTekst;
    }

    protected String Brukernavn
    {
        get
        {
            if (Session["Logginn_bruker"] != null)
            {
                return (String)Session["Logginn_bruker"];
            }
            else
            {   
                return "Brukernavnet ikke angitt";
            }
        }

        set
        {
            Session["Logginn_bruker"] = value;
        }

    }
   

    protected void LoggUt(object sender, EventArgs e)
    {
        Session["Logginn_bruker"] = null;

        Session.Remove("Brukernavn");
        Session.RemoveAll();

        Response.Redirect("LoggInn.aspx");
    }
}
