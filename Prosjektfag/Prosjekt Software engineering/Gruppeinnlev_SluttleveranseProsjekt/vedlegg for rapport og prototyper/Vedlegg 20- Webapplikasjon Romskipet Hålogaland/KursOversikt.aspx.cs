using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class KursOversikt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LagKursHeader();
            StartVisning();

            LagAktivitetsHeader();
            LagAktivitetsListe();
        }
    }

    protected void LagKursHeader()
    {
        StringBuilder sbKursHeader = new StringBuilder();
        sbKursHeader.Append("<table><tr class='kursHead'><td>Kursnavn</td><td>Målgruppe</td><td>Startdato</td><td>Sluttdato</td><td>Mer informasjon</td><td>Påmelding</td></tr>");
        litKursHeader.Text = sbKursHeader.ToString();
    }

    protected void LagAktivitetsHeader()
    {
        StringBuilder sbAktivitetsHeader = new StringBuilder();
        sbAktivitetsHeader.Append("<table><tr class='aktivitetsHead'><td>Aktivitetsnavn</td><td>Startdato</td><td>Sluttdato</td><td>Mer informasjon</td><td>Påmelding</td></tr>");
        litAktivitetsHeader.Text = sbAktivitetsHeader.ToString();
    }

    protected void StartVisning()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> alleKursListe = (from kurs in kobling.Kurs orderby kurs.KursID descending select kurs).ToList();
            LagListe(alleKursListe);
        }
    }

    protected void VisAlleKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> alleKursListe = (from kurs in kobling.Kurs select kurs).ToList();
            LagListe(alleKursListe);
        }
    }

    protected void VisStudentKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> studentKursListe = (from kurs in kobling.Kurs where kurs.Målgruppe == "Studenter" select kurs).ToList();
            LagListe(studentKursListe);
        }
    }

    protected void VisLærerKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> lærerKursListe = (from kurs in kobling.Kurs where kurs.Målgruppe == "Lærere" select kurs).ToList();
            LagListe(lærerKursListe);
        }
    }

    protected void VisEleverKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> eleverKursListe = (from kurs in kobling.Kurs where kurs.Målgruppe == "Elever" select kurs).ToList();
            LagListe(eleverKursListe);
        }
    }

    protected void LagListe(List<Kurs> kursliste)
    {
        StringBuilder sbKursListe = new StringBuilder();
        String radType;
        int teller = 0;

        foreach (Kurs kurs in kursliste) 
        {
            if (teller % 2 == 0)
            {
                radType = "row1";
            }
            else { radType = "row2"; }

            sbKursListe.AppendFormat("<tr class='{0}'><td>{1}</td><td>{5}</td><td>{2}</td><td>{3}</td><td><a href='KursProfil.aspx?kursID={4}'>Les mer</a></td><td><a href='MeldPåKurs.aspx?kursID={4}'>Meld meg på</a></td></tr>",
            radType,
            kurs.Kursnavn,
            kurs.Startdato.ToShortDateString(),
            kurs.Sluttdato.ToShortDateString(),
            kurs.KursID,
            kurs.Målgruppe
            );
            teller++;
        }
        sbKursListe.Append("</table>");

        litKursliste.Text = sbKursListe.ToString();
    }

    protected void LagAktivitetsListe()
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                StringBuilder sbAktivitetsListe = new StringBuilder();
                String radType;
                int teller = 0;
                List<Aktivitet> aktivitetsListe = (from aktiviteter in kobling.Aktivitets select aktiviteter).ToList();

                foreach (Aktivitet aktivitet in aktivitetsListe)
                {
                    if (teller % 2 == 0)
                    {
                        radType = "row1";
                    }
                    else { radType = "row2"; }

                    sbAktivitetsListe.AppendFormat("<tr class='{0}'><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='AktivitetProfil.aspx?AktivitetID={4}'>Les mer</a></td><td><a href='MeldPåAktivitet.aspx?AktivitetID={4}'>Meld meg på</a></td></tr>",
                        radType,
                        aktivitet.AktivitetNavn,
                        aktivitet.Startdato.ToShortDateString(),
                        aktivitet.Sluttdato.ToShortDateString(),
                        aktivitet.AktivitetID
                    );
                }

                sbAktivitetsListe.Append("</table>");
                litAktivitetsliste.Text = sbAktivitetsListe.ToString();
            }
        }
        catch (Exception ex)
        {

        }
    }
}