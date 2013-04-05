using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Xml.Linq;

public partial class Logginn : System.Web.UI.Page
{
    String filsti;

    protected void Page_Load(object sender, EventArgs e)
    {
        filsti = Server.MapPath("XML/ansatt.xml");
    }

    protected void LoggInn(object sender, EventArgs e)
    {
        LoggInnHandler nyLoggInnHandler = new LoggInnHandler {hentBrukernavn, hentPassord};

        String brukernavn = txtBrukernavn.Text;
        String passord = txtPassord.Text;

        bool loggInnOk = nyLoggInnHandler.SjekkOmRiktigLoggInn(brukernavn, passord);
        String statustekst;

        if (loggInnOk)
        {
            Brukernavn = brukernavn;
            Response.Redirect("Registrering.aspx");
            statustekst = "Du er logget inn som: " + brukernavn;        
        }
        else
        {
            Response.Redirect("Logginn.aspx");
            statustekst = "Innlogging feilet, forsøk på nytt.";
        }
    }

    protected XElement hentBrukernavn(String bId)
    {
        try
        {
            XElement xmlBrukernavn = XElement.Load(filsti);

            var valgtBrukernavn = (from ansatt in xmlBrukernavn.Descendants("ansatt")
                                   where (String)ansatt.Element("brukernavn") == bId
                                   select ansatt).SingleOrDefault();
            return valgtBrukernavn; 
        }
        catch (Exception ex)
        {
            litTilbakemelding.Text = "Feil ved filoppkobling! Fant ikke brukernavn.";
            return null;
        }
        
    }

    protected XElement hentPassord(String pId)
    {
        try
        {
            XElement xmlPassord = XElement.Load(filsti);
            var valgtPassord = (from ansatt in xmlPassord.Descendants("ansatt")
                                    where (String)ansatt.Element("passord") == pId
                                    select ansatt).SingleOrDefault();
            return valgtPassord;
        }
        catch (Exception ex)
        {
            litTilbakemelding.Text = "Feil ved filoppkobling! fant ikke passord";
            return null;
        }
    
    }

    protected void HentBruker(object sender, EventArgs e)
    {
        var valgtBrukernavn = hentBrukernavn(txtBrukernavn.Text);
        var valgtPassord = hentPassord(txtPassord.Text);

        if (valgtBrukernavn != null && valgtPassord != null)
        {
            txtBrukernavn.Text = (String)valgtBrukernavn.Element("Brukernavn");
            txtPassord.Text = (String)valgtPassord.Element("Passord");
        }
        else
        {
            litTilbakemelding.Text = "Finner ikke brukernavn/passord. Forsøk på nytt";
        }
    }

    protected String Brukernavn
    {
        get
        {
            if (Session["Brukernavn"] != null)
            {
                return (String)Session["Brukernavn"];
            }
            else
            {
                Response.Redirect("Logginn.aspx");
                return "Bruker ikke angitt";
            }
        }
        set
        {
            Session["Brukernavn"] = value;
        }
    }
}
