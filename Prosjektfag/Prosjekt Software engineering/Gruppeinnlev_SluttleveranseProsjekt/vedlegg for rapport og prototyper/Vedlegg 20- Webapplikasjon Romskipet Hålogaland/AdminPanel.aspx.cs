using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class AdminPanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] == null)
        {
            Response.Redirect("LoggInn.aspx");
        }

        LagKursHeader();
        StartVisning();

        LagAktivitetsHeader();
        LagAktivitetsListe();

        LagNyhetsHeader();
        LagNyhetsListe();

        LagProduktHeader();
        HentProduktListe();

        FyllAdminBildeGalleri();
    }

    protected void LagKursHeader()
    {
        StringBuilder sbKursHeader = new StringBuilder();
        sbKursHeader.Append("<table><tr class='kursHead'><td>KursID</td><td>Kursnavn</td><td>Målgruppe</td><td>Se kurs</td><td>Rediger kurs</td></tr>");
        litKursHeader.Text = sbKursHeader.ToString();
    }

    protected void LagAktivitetsHeader()
    {
        StringBuilder sbAktivitetsHeader = new StringBuilder();
        sbAktivitetsHeader.Append("<table><tr class='aktivitetsHead'><td>Aktivitetsnavn</td><td>Startdato</td><td>Sluttdato</td><td>Mer informasjon</td><td>Rediger aktivitet</td></tr>");
        litAktivitetsHeader.Text = sbAktivitetsHeader.ToString();
    }

    protected void LagNyhetsHeader()
    {
        litNyhetsHeader.Text = "<table><tr class='nyhetsHead'><td>NyhetsID</td><td>Tittel</td><td>Se nyhet</td><td>Rediger nyhet</td></tr>";
    }

    protected void LagProduktHeader()
    {
        litProduktHeader.Text = "<table><tr class='nyhetsHead'><td>ProduktID</td><td>Produktnavn</td><td>Pris</td><td>Rediger produkt</td></tr>";
    }

    protected void LagNyhetsListe()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Nyhet> nyhetsListe = (from nyheter in kobling.Nyhets orderby nyheter.NyhetsID descending select nyheter).ToList();
            StringBuilder sbNyhetsListe = new StringBuilder();
            String radType;
            int teller = 0;

            foreach (var nyhet in nyhetsListe)
            {
                if (teller % 2 == 0)
                {
                    radType = "row1";
                }
                else { radType = "row2"; }

                sbNyhetsListe.AppendFormat("<tr class='{0}'><td>{1}</td><td>{2}</td><td><a href='AktueltProfil.aspx?NyhetsID={1}'>Gå til nyhet</a></td><td><a href='RedigerNyhet.aspx?NyhetID={1}'><img src='gfx/cog.png' class='imgNoStyle' alt='Rediger kurs' /></a></tr>",
                    radType,
                    nyhet.NyhetsID,
                    nyhet.Tittel
                );

                teller++;
            }

            sbNyhetsListe.Append("</table>");
            litNyhetsListe.Text = sbNyhetsListe.ToString();
        }
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
            List<Kurs> alleKursListe = (from kurs in kobling.Kurs orderby kurs.KursID descending select kurs).ToList();
            LagListe(alleKursListe);
        }
    }

    protected void VisStudentKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> studentKursListe = (from kurs in kobling.Kurs where kurs.Målgruppe == "Studenter" orderby kurs.KursID descending select kurs).ToList();
            LagListe(studentKursListe);
        }
    }

    protected void VisLærerKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> lærerKursListe = (from kurs in kobling.Kurs where kurs.Målgruppe == "Lærere" orderby kurs.KursID descending select kurs).ToList();
            LagListe(lærerKursListe);
        }
    }

    protected void VisEleverKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> eleverKursListe = (from kurs in kobling.Kurs where kurs.Målgruppe == "Elever" orderby kurs.KursID descending select kurs).ToList();
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

            sbKursListe.AppendFormat("<tr class='{0}'><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='KursProfil.aspx?kursID={1}'>Gå til kurs</a></td><td><a href='RedigerKurs.aspx?kursID={1}'><img src='gfx/cog.png' class='imgNoStyle' alt='Rediger kurs' /></a></td></tr>",
                radType,
                kurs.KursID,
                kurs.Kursnavn,
                kurs.Målgruppe
            );

            teller++;
        }
        sbKursListe.Append("</table>");

        litKursliste.Text = sbKursListe.ToString();
    }

    protected void LastOppBilde(object sender, EventArgs e)
    {
        if (fuMediaOpplasting.HasFile)
        {
            System.Drawing.Image filobjekt = System.Drawing.Image.FromStream(fuMediaOpplasting.PostedFile.InputStream);
            filobjekt.Save(Server.MapPath("img/Media/") + txtBildeTittel.Text + ".jpg");

            try
            {
                using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
                {
                    Bilder nyttBilde = new Bilder {
                        Bildenavn = txtBildeTittel.Text,
                        Path = "img/Media/" + txtBildeTittel.Text + ".jpg"
                        
                    };

                    kobling.Bilders.InsertOnSubmit(nyttBilde);
                    kobling.SubmitChanges();
                }

                Response.Redirect(Request.Url.ToString());
            }
            catch (Exception ex)
            {

            }
        }
    }

    protected void FyllAdminBildeGalleri()
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                List<Bilder> bildeListe = (from bilder in kobling.Bilders select bilder).ToList();
                StringBuilder sbBildeListe = new StringBuilder();

                foreach (var bilde in bildeListe)
                {
                    sbBildeListe.AppendFormat("<div class='adminBildeContainer'><div class='btnSlettBilde'><a href='SlettMedia.aspx?BildeID={1}'><img src='gfx/lukk.png'></div></a><img src='{0}'> <p>{2}</p></div>",
                        bilde.Path,
                        bilde.BildeID,
                        bilde.Bildenavn
                        );
                }

                litAdminBildeGalleri.Text = sbBildeListe.ToString();
            }
        }
        catch (Exception ex)
        {

        }
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
                List<Aktivitet> aktivitetsListe = (from aktiviteter in kobling.Aktivitets orderby aktiviteter.AktivitetID descending select aktiviteter).ToList();

                foreach (Aktivitet aktivitet in aktivitetsListe)
                {
                    if (teller % 2 == 0)
                    {
                        radType = "row1";
                    }
                    else { radType = "row2"; }

                    sbAktivitetsListe.AppendFormat("<tr class='{0}'><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='AktivitetProfil.aspx?AktivitetID={4}'>Les mer</a></td><td><a href='RedigerAktivitet.aspx?AktivitetID={4}'><img src='gfx/cog.png' class='imgNoStyle' alt='Rediger kurs' /></a</td></tr>",
                        radType,
                        aktivitet.AktivitetNavn,
                        aktivitet.Startdato.ToShortDateString(),
                        aktivitet.Sluttdato.ToShortDateString(),
                        aktivitet.AktivitetID
                    );
                }

                sbAktivitetsListe.Append("</table>");
                litAktivitetsListe.Text = sbAktivitetsListe.ToString();
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void HentProduktListe()
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                StringBuilder sbProduktListe = new StringBuilder();
                String radType;
                int teller = 0;
                List<Produkt> produktListe = (from produkter in kobling.Produkts orderby produkter.ProduktID descending select produkter).ToList();

                foreach (Produkt produkt in produktListe)
                {
                    if (teller % 2 == 0)
                    {
                        radType = "row1";
                    }
                    else { radType = "row2"; }

                    sbProduktListe.AppendFormat("<tr class='{0}'><td>{1}</td><td>{2}</td><td>{3}</td><td><a href='RedigerProdukt.aspx?ProduktID={1}'><img src='gfx/cog.png' class='imgNoStyle'></td></tr>",
                        radType,
                        produkt.ProduktID,
                        produkt.ProduktNavn,
                        produkt.Pris
                        
                    );
                    teller++;
                }
                sbProduktListe.Append("</table>");
                litProduktliste.Text = sbProduktListe.ToString();
            }
        }
        catch (Exception ex)
        {

        }
    }
}