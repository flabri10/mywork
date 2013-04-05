using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logginn : System.Web.UI.Page
{
    String[] sessionData = new String[3];

    protected void Page_Load(object sender, EventArgs e)
    {
        SjekkSessions();
    }

    protected void LoggInn(object sender, EventArgs e)
    {
        String brukernavn = txtBrukernavn.Text;

        LoggInnHandler loggInnHandler = new LoggInnHandler();

        bool brukerLoggInnOK = loggInnHandler.sjekkBrukerLoggInn(txtBrukernavn.Text, txtPassord.Text);

        if (brukerLoggInnOK)
        {
            Session.RemoveAll();
            LagBrukerSession();
            Response.Redirect("Bilder.aspx");
        }
        else
        {
            litLoggInnStatus.Text = "Brukernavn/passord er feil";
        }
    }

    protected void LagBrukerSession()
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
        {
            Bruker loggetInnBruker = (from bruker in kobling.Brukers where txtBrukernavn.Text == bruker.Brukernavn select bruker).SingleOrDefault();
            
            sessionData[0] = Convert.ToString(loggetInnBruker.BrukerId);
            sessionData[1] = loggetInnBruker.Brukernavn;
            sessionData[2] = loggetInnBruker.Passord;

            Session["BrukerSession"] = sessionData;
        }
    }

    protected void SjekkSessions()
    {
        if (Session["BrukerSession"] != null)
        {
            int innloggetBruker = ((int[])Session["BrukerSession"])[2];
        }
        else
        {
            Response.Redirect("Logginn.aspx");
        }
    }
}