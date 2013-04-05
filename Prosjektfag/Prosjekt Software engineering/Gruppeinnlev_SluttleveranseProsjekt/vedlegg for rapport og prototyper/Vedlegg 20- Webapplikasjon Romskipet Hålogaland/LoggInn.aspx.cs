using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoggInn : System.Web.UI.Page
{
    String[] sessionData = new String[6];

    protected void Page_Load(object sender, EventArgs e)
    {
        SjekkSessions();
    }
    protected void RegistrerBruker(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            String brukernavn = txtBrukernavn.Text;
            String[] splitTabell = brukernavn.Split('@');
            String epost = splitTabell[1];

            if (epost != "rh.no")
            {
                Bruker nyBruker = new Bruker
                {
                    Brukernavn = txtBrukernavn.Text,
                    Passord = txtPassord.Text,
                    Fornavn = txtFornavn.Text,
                    Etternavn = txtEtternavn.Text,
                    Mobil = Convert.ToInt32(txtMobil.Text)
                };

                kobling.Brukers.InsertOnSubmit(nyBruker);

                litRegistrerTilbakemelding.Text = "<p class='success'><img src='gfx/success.png' alt='Suksess' class='imgNoStyle'/> Du er nå registrert! </p>";

                kobling.SubmitChanges();
                
                sessionData[0] = Convert.ToString(nyBruker.BrukerID);
                sessionData[1] = nyBruker.Brukernavn;
                sessionData[2] = nyBruker.Passord;
                sessionData[3] = nyBruker.Fornavn;
                sessionData[4] = nyBruker.Etternavn;
                sessionData[5] = Convert.ToString(nyBruker.Mobil);

                Session["BrukerSession"] = sessionData;
               
                Response.Redirect(Request.Url.ToString());
            }

            else
            {
                litRegistrerTilbakemelding.Text = "<p class='failure'>Du kan ikke registrere deg med denne mailen. Dette er en reservert mail som brukes av ansatte ved Romskipet Hålogaland.</p>";
            }

        }
    }

    protected void _LoggInn(object sender, EventArgs e)
    {
        String brukernavn = txtBrukernavnLoggInn.Text;
        String [] splitTabell = brukernavn.Split('@');

        String epost = splitTabell[1];

        LoggInnHandler loggInnHandler = new LoggInnHandler();

        if (epost == "rh.no")
        {
            bool adminLoggInnOK = loggInnHandler.sjekkAdminLoggInn(txtBrukernavnLoggInn.Text, txtPassordLoggInn.Text);

            if (adminLoggInnOK)
            {
                Session.Remove("BrukerSession");
                LagAdminSession();
                Response.Redirect("AdminPanel.aspx");
            }

            else
            {
                litLoggInnTilbakemelding.Text = "Brukernavn/passord er feil";
            }
        }

        else
        {
            bool brukerLoggInnOK = loggInnHandler.sjekkBrukerLoggInn(txtBrukernavnLoggInn.Text, txtPassordLoggInn.Text);

            if (brukerLoggInnOK)
            {
                Session.Remove("AdministratorSession");
                LagBrukerSession();
                Response.Redirect("Forside.aspx");
            }

            else
            {
                litLoggInnTilbakemelding.Text = "Brukernavn/passord er feil";
            }
        }
    }

    protected void LagAdminSession()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Administrator loggetInnAdministrator = (from administrator in kobling.Administrators where txtBrukernavnLoggInn.Text == administrator.Brukernavn select administrator).SingleOrDefault();

            sessionData[0] = Convert.ToString(loggetInnAdministrator.AdminID);
            sessionData[1] = loggetInnAdministrator.Brukernavn;
            sessionData[2] = loggetInnAdministrator.Passord;
            sessionData[3] = loggetInnAdministrator.Fornavn;
            sessionData[4] = loggetInnAdministrator.Etternavn;
            sessionData[5] = Convert.ToString(loggetInnAdministrator.Mobil);

            Session["AdministratorSession"] = sessionData;

        }
    }

    protected void LagBrukerSession()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Bruker loggetInnBruker = (from bruker in kobling.Brukers where txtBrukernavnLoggInn.Text == bruker.Brukernavn select bruker).SingleOrDefault();

            sessionData[0] = Convert.ToString(loggetInnBruker.BrukerID);
            sessionData[1] = loggetInnBruker.Brukernavn;
            sessionData[2] = loggetInnBruker.Passord;
            sessionData[3] = loggetInnBruker.Fornavn;
            sessionData[4] = loggetInnBruker.Etternavn;
            sessionData[5] = Convert.ToString(loggetInnBruker.Mobil);

            Session["BrukerSession"] = sessionData;
        }
    }

    protected void SjekkSessions()
    {
        if (Session["AdministratorSession"] != null)
        {
            litLoggInnTilbakemelding.Text = "Du er logget inn som " + ((String[])Session["AdministratorSession"])[3] + " " + ((String[])Session["AdministratorSession"])[4] + ". Du har dermed administratorrettigheter.";
        }

        if (Session["BrukerSession"] != null)
        {
            litLoggInnTilbakemelding.Text = "Du er logget inn som " + ((String[])Session["BrukerSession"])[3] + " " + ((String[])Session["BrukerSession"])[4] + ".";
        }
    }
}