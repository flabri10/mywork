using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class KursProfil : System.Web.UI.Page
{
    String id;

    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("kursID");
        SjekkSessions();
        VisProfil(id);
   }

    protected void VisProfil(String kursID)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                Kurs valgtKurs = (from kurs in kobling.Kurs where kurs.KursID == Convert.ToInt32(kursID) select kurs).SingleOrDefault();
                List<ForeleserPåmelding> foreleserListe = (from foreleserPåmelding in kobling.ForeleserPåmeldings where foreleserPåmelding.KursID == Convert.ToInt32(kursID) select foreleserPåmelding).ToList();

                StringBuilder sbKursBeskrivelse = new StringBuilder();

                sbKursBeskrivelse.AppendFormat("<p>{0}</p><div class='linkButton'><a href='MeldPåKurs.aspx?kursID={1}'>Påmelding</a></div>",
                    valgtKurs.Beskrivelse,
                    id
                );

                //Skriv ut forelesere
                StringBuilder sbForeleserListe = new StringBuilder();
                String strForeleserListe;
                sbForeleserListe.Append("<ul>");

                foreach (ForeleserPåmelding foreleserPåmelding in foreleserListe)
                {
                    sbForeleserListe.AppendFormat("<li>{0} {1} {2}</li>",
                        foreleserPåmelding.Foreleser.Utdanning,
                        foreleserPåmelding.Foreleser.Fornavn,
                        foreleserPåmelding.Foreleser.Etternavn
                        );
                }
                sbForeleserListe.Append("</ul>");
                strForeleserListe = sbForeleserListe.ToString();

                //Skriver ut deltakere
                StringBuilder sbDeltakerListe = new StringBuilder();
                List<KursPåmelding> deltakerListe = (from kursPåmelding in kobling.KursPåmeldings where kursPåmelding.KursID == Convert.ToInt32(kursID) select kursPåmelding).ToList();

                sbDeltakerListe.Append("<ul>");

                foreach (KursPåmelding kursPåmelding in deltakerListe)
                {
                    sbDeltakerListe.AppendFormat("<li>{0} {1}<ul><li>Tlf: {2}</li><li>{3}</li></ul></li>",
                        kursPåmelding.Bruker.Fornavn,
                        kursPåmelding.Bruker.Etternavn,
                        kursPåmelding.Bruker.Mobil,
                        kursPåmelding.Bruker.Brukernavn
                    );
                }

                litDeltakerListe.Text = sbDeltakerListe.ToString();

                //Skriv ut til KursInfo
                StringBuilder sbKursInfo = new StringBuilder();
                sbKursInfo.AppendFormat("<h3>Påmeldingsfrist</h3><p>{0}</p><h3>Kursperiode</h3><p>{1} - {2}</p><h3>Samarbeidspartnere</h3><p>{3}</p><h3>Ankomst/Avreise</h3><p>{4}</p><h3>Forelesere</h3>{5}",
                    valgtKurs.Påmeldingsfrist.ToShortDateString(),
                    valgtKurs.Startdato.ToShortDateString(),
                    valgtKurs.Sluttdato.ToShortDateString(),
                    valgtKurs.Samarbeidspartnere,
                    valgtKurs.Tilleggsinformasjon,
                    strForeleserListe
                );

                //Skriver ut til Literals
                litKursNavn.Text = valgtKurs.Kursnavn;
                litKursInfo.Text = sbKursInfo.ToString();
                litKursBeskrivelse.Text = sbKursBeskrivelse.ToString();
                litAntallPåmeldte.Text = Convert.ToString(deltakerListe.Count() + "/" + valgtKurs.MaxAntallDeltakere + " (se deltakerliste)");
                
                
            }

            catch (Exception)
            {
                litFeilmelding.Text = "Kurset finnes ikke.";
            }
        }
    }

    protected void SendTilRedigering(object sender, EventArgs e)
    {
        Response.Redirect("RedigerKurs.aspx?kursID=" + id);
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