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
    public partial class nyanmeldelse : System.Web.UI.Page
    {
        String filsti;

        protected void Page_Load(object sender, EventArgs e)
        {
            filsti = Server.MapPath("xmlFilmanmeldelseliste.xml");
        }

        protected void leggTilAnmeldelse(object sender, EventArgs e)
        {
            try
            {
                XElement xmlFilmanmeldelseliste = XElement.Load(filsti);          

                xmlFilmanmeldelseliste.Add(
                    new XElement("filmanmeldelse",
                        new XElement("tittel", txtTittel.Text),
                        new XElement("tidspunkt", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")),
                        new XElement("epost", txtEpost.Text),
                        new XElement("anmeldelse", txtAnmeldelse.Text),
                        new XElement("vurdering", rblVurdering.Text)
                    )
                );

                xmlFilmanmeldelseliste.Save(filsti);

                Response.Redirect("filmanmeldelser.aspx");
            }
            catch (Exception ex)
            {
                litListe.Text = "Feil ved filoppkobling.";
            }
        }

    }
}