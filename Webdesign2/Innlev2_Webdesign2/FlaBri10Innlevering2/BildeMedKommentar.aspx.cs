using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class BildeMedKommentar : System.Web.UI.Page
{
    String innloggetBrukernavn;
    protected void Page_Load(object sender, EventArgs e)
    {
        VisBilde();
        VisKommentarliste();
    }

    protected void VisBilde()
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
        {
            try
            {
                var bildeliste = from bilder in kobling.Bildes
                                 select bilder;

                StringBuilder sbBildeliste = new StringBuilder();

                sbBildeliste.Append("<ul>");

                foreach (var bilde in bildeliste)
                {

                    sbBildeliste.AppendFormat("<li><h3>{0}</h3><img src='Bilder/{1}' alt='{0}'/><a href='BildeMedKommentar.aspx?id={2}&bildeId={3}' alt='{0}'>Se kommentarer</a></li>",
                        bilde.Tittel,
                        bilde.Bildenavn,
                        bilde.KommentarId,
                        bilde.BrukerId);
                }
                sbBildeliste.Append("</ul>");

                litBilde.Text = sbBildeliste.ToString();
            }
            catch (Exception ex)
            {
                litBilde.Text = ex.Message;
            }
        }
    }

    protected void VisKommentarliste()
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
        {
            try
            {
                var brukerKommentarliste = from kommentar in kobling.Kommentars
                                           join bruker in kobling.Brukers on kommentar.BrukerId equals bruker.BrukerId
                                           select new
                                           {
                                               Profilbilde = bruker.Profilbilde,
                                               Tittel = kommentar.Tittel,
                                               Brukernavn = bruker.Brukernavn,
                                               Innhold = kommentar.Innhold
                                           };

                StringBuilder sbKommentarliste = new StringBuilder();

                foreach (var kommentar in brukerKommentarliste)
                {
                    sbKommentarliste.AppendFormat("<img class='imgProfilbilde' src='Bilder/{0}' alt'profilbilde til bruker'/><br/><h3>{1}</h3><br/><u>{2}</u><br/><p>{3}</p>",
                        bruker.Profilbilde,
                        kommentar.Tittel,
                        bruker.Brukernavn,
                        kommentar.Innhold);
                }

                litKommentarliste.Text = sbKommentarliste.ToString();
            }
            catch (Exception ex)
            {
                litKommentarliste.Text = ex.Message;
            }
        }    
    }

    protected void btnKommenter_Click(object sender, EventArgs e)
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
        {
            try
            {
                SjekkSessions();
                Kommentar nyKommentar = new Kommentar();
                nyKommentar.Brukernavn = innloggetBrukernavn;
                nyKommentar.Tittel = txtTittel.Text;
                nyKommentar.Innhold = txtKommentar.Text;

                kobling.Kommentars.InsertOnSubmit(nyKommentar);
                kobling.SubmitChanges();
                kobling.Connection.Close();

                Response.Redirect(Request.Url.ToString());
            }
            catch (Exception ex)
            {
                litPostKommentar.Text = ex.Message+"<br/> Kunne ikke poste kommentar. Prøv på nytt!";
            }
        }
    }

    protected void SjekkSessions()
    {
        if (Session["BrukerSession"] != null)
        {
            int innloggetBrukerId = ((int[])Session["BrukerSession"])[2];
            String innloggetBrukernavn = ((String[])Session["BrukerSession"])[0];
        }
    }
}
