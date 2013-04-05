using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text;

namespace Innlevering3_flabri10
{
    public partial class filmanmeldelser : System.Web.UI.Page
    {
        String filsti;
        XElement xmlFilmanmeldelseliste;
        StringBuilder sbFilmanmeldelsesliste = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            filsti = Server.MapPath("xmlFilmanmeldelseliste.xml");

            if (!IsPostBack)
            {
                FyllAnmeldelseListe();
            }
        }

        protected void FyllAnmeldelseListe()
        {
            try
            {
                xmlFilmanmeldelseliste = XElement.Load(filsti);

                var filmanmeldelseliste = from filmanmeldelser in xmlFilmanmeldelseliste.Descendants("filmanmeldelse") select filmanmeldelser;

                foreach (var filmanmeldelse in filmanmeldelseliste)
                {
                    sbFilmanmeldelsesliste.AppendFormat("<article class='modul'><h3>{0}</h3><p><i>Tidspunkt: {1}</i></br><i>Skrevet av: {2}</i></br>Terningkast: {3}</br>Anmeldelse: {4}</p></article>",
                        (String)filmanmeldelse.Element("tittel"),
                        (String)filmanmeldelse.Element("tidspunkt"),
                        (String)filmanmeldelse.Element("epost"),
                        (String)filmanmeldelse.Element("vurdering"),
                        (String)filmanmeldelse.Element("anmeldelse")
                    );
                }
                litListe.Text = sbFilmanmeldelsesliste.ToString();
            }
            catch (Exception ex)
            {
                litListe.Text = "Feil ved filkobling.";
            }
        }

        protected XElement HentFil()
        {
            try
            {
                xmlFilmanmeldelseliste = XElement.Load(filsti);
                return xmlFilmanmeldelseliste;
            }
            catch (Exception ex)
            {
                litListe.Text = "Noe gikk galt ved filhenting";
                return null;
            }
        }
        
        protected XElement HentAnmeldelseEtterEpost(String soekEpost)
        {
            try
            {
                soekEpost = txtSoekEpost.Text;
                xmlFilmanmeldelseliste = XElement.Load(filsti);
                var valgtAnmeldelse = (from filmanmeldelse in xmlFilmanmeldelseliste.Descendants("filmanmeldelse")
                                      where (String)filmanmeldelse.Element("epost") == soekEpost
                                      select filmanmeldelse).SingleOrDefault();
                return valgtAnmeldelse;
            }
            catch (Exception ex)
            {
                litListe.Text = "Feil ved filoppkobling!";
                return null;
            }
        }

        protected void HentAnmeldelse(object sender, EventArgs e)
        {
            try
            {
                var valgtAnmeldelse = HentAnmeldelseEtterEpost(txtSoekEpost.Text);

                lblResultatEpost.Text = "Resultat fra epostsøk: " + (String)valgtAnmeldelse.Element("epost");

                if (valgtAnmeldelse != null)
                {                    
                    sbFilmanmeldelsesliste.AppendFormat("<article class='modul'><h3>{0}</h3><p><i>Tidspunkt: {1}</i></br><i>Skrevet av: {2}</i></br>Terningkast: {3}</br>Anmeldelse: {4}</p></article>",
                        (String)valgtAnmeldelse.Element("tittel"),
                        (String)valgtAnmeldelse.Element("tidspunkt"),
                        (String)valgtAnmeldelse.Element("epost"),
                        (String)valgtAnmeldelse.Element("vurdering"),
                        (String)valgtAnmeldelse.Element("anmeldelse")
                    );
                    
                    litListe.Text = sbFilmanmeldelsesliste.ToString();
                }
                else
                {
                    litListe.Text = "Finner ingen anmeldelse fra denne epost-adressen.";
                }
            }
            catch(NullReferenceException nre)
            {
                litListe.Text = "Noe gikk galt med søket.";
            }
        }
    }
}   