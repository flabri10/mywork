using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class AktivitetProfil : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("AktivitetID");
        SjekkSessions();
        HentProfil();
    }

    protected void HentProfil()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Aktivitet valgtAktivitet = (from aktivitet in kobling.Aktivitets where aktivitet.AktivitetID == Convert.ToInt32(id) select aktivitet).SingleOrDefault();

            litAktivitetNavn.Text = valgtAktivitet.AktivitetNavn;

            StringBuilder sbKursInfo = new StringBuilder();
            sbKursInfo.AppendFormat("<h3>Startdato</h3><p>{0}</p><h3>Sluttdato</h3><p>{1}</p><h3>Starttidspunkt</h3><p>{2}</p><h3>Sluttidspunkt</h3><p>{3}</p>",
                valgtAktivitet.Startdato.ToShortDateString(),
                valgtAktivitet.Sluttdato.ToShortDateString(),
                valgtAktivitet.StartTidspunkt,
                valgtAktivitet.SluttTidspunkt

            );

            litKursInfo.Text = sbKursInfo.ToString();

            //Skriver ut deltakere
            StringBuilder sbDeltakerListe = new StringBuilder();
            List<AktivitetPåmelding> deltakerListe = (from aktivitetPåmelding in kobling.AktivitetPåmeldings where aktivitetPåmelding.AktivitetID == Convert.ToInt32(id) select aktivitetPåmelding).ToList();

            sbDeltakerListe.Append("<ul>");

            foreach (AktivitetPåmelding aktivitetPåmelding in deltakerListe)
            {
                sbDeltakerListe.AppendFormat("<li>{0} {1}<ul><li>Tlf: {2}</li><li>{3}</li></ul></li>",
                    aktivitetPåmelding.Bruker.Fornavn,
                    aktivitetPåmelding.Bruker.Etternavn,
                    aktivitetPåmelding.Bruker.Mobil,
                    aktivitetPåmelding.Bruker.Brukernavn
                );
            }

            litDeltakerListe.Text = sbDeltakerListe.ToString();
            litAntallPåmeldte.Text = deltakerListe.Count + " påmeldte (se påmeldte)";

            StringBuilder sbKursAktivitetsBeskrivelse = new StringBuilder();

            sbKursAktivitetsBeskrivelse.AppendFormat("<p>{0}</p><div class='linkButton'><a href='MeldPåAktivitet.aspx?AktivitetID={1}'>Påmelding</a></div>",
                valgtAktivitet.Beskrivelse,
                id
            );

            litAktivitetBeskrivelse.Text = sbKursAktivitetsBeskrivelse.ToString();
            
        }
    }

    protected void SjekkSessions()
    {
        if (Session["AdministratorSession"] == null)
        {
            pnlAdminInfo.Visible = false;
        }

        if (Session["PåmeldingSuksess"] != null)
        {
            litPåmeldingTilbakemelding.Text = (String)Session["PåmeldingSuksess"];
            Session.Remove("PåmeldingSuksess");
        }
    }
}
