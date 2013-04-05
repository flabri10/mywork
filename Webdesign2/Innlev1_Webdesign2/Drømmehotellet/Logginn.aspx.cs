using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Logginn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Logginn_bruker(object sender, EventArgs e)
    {
        string brukernavn;
        string passord;
        string tempBruker = "";
        string tempPassord = "";
        bool LogginnStatus = false;

        brukernavn = txtBrukernavn.Text;
        passord = txtPassord.Text;

        XmlDocument xd = new XmlDocument();
        xd.Load(Server.MapPath("Xmlfiler/ansatt.xml"));

        XmlNodeList xnl = xd.GetElementsByTagName("ansatt");

        foreach (XmlNode xn in xnl)
        {
            XmlNodeList cxnl = xn.ChildNodes;

            foreach (XmlNode cxn in cxnl)
            {
                if (cxn.Name == "brukernavn")
                {
                    if (cxn.InnerText == brukernavn)
                    {
                        tempBruker = brukernavn;
                    }

                }

                if (cxn.Name == "passord")
                {
                    if (cxn.InnerText == passord)
                    {
                        tempPassord = passord;
                    }
                }
            }

            if ((tempBruker != "") && (tempPassord != ""))
            {
                LogginnStatus = true;
            }
        }

        if (LogginnStatus == true)
        {
            Session["Logginn_bruker"] = brukernavn;
            Session.Timeout = 1;

            Response.Redirect("registrering.aspx");
        }
        else
        {
            Session["Logginn_bruker"] = "";
        }

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
            statusTekst = "Feil med innlogging!";
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
}



  