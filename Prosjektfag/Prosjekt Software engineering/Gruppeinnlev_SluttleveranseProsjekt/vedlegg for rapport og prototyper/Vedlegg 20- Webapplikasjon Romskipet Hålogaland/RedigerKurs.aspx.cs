using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RedigerKurs : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] == null)
        {
            Response.Redirect("Forside.aspx");
        }
        id = Request.Params.Get("kursID");
       
        if (!IsPostBack)
        {
            FyllKursInfo();
        }
        
    }

    protected void FyllKursInfo()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                Kurs valgtKurs = (from kurs in kobling.Kurs where kurs.KursID == Convert.ToInt32(id) select kurs).SingleOrDefault();

                String redigertKursBeskrivelse = valgtKurs.Beskrivelse.Replace("<br>", "\r\n");
                String redigertSamarbeidspartere = valgtKurs.Samarbeidspartnere.Replace("<br>", "\r\n");

                //Fylller alle inputelementer
                txtKursnavn.Text = valgtKurs.Kursnavn;
                txtKursBeskrivelse.Text = redigertKursBeskrivelse;
                txtPåmeldingsfrist.Text = valgtKurs.Påmeldingsfrist.ToShortDateString();
                txtStartdato.Text = valgtKurs.Startdato.ToShortDateString();
                txtSluttdato.Text = valgtKurs.Sluttdato.ToShortDateString();
                txtMaksAntallDeltakere.Text = Convert.ToString(valgtKurs.MaxAntallDeltakere);
                txtTilleggsInformasjon.Text = valgtKurs.Tilleggsinformasjon;
                txtKursansvarlig.Text = valgtKurs.KursAnsvarlig;
                txtSamarbeidspartnere.Text = redigertSamarbeidspartere;
            }
            catch (Exception)
            {
                litFeilmelding.Text = "<span style='color:red'>Dette kurset finnes ikke!</span>";
            }
        }
    }

    protected void LagreEndringer(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                Kurs valgtKurs = (from kurs in kobling.Kurs where kurs.KursID == Convert.ToInt32(id) select kurs).SingleOrDefault();

                String redigertKursBeskrivelse = txtKursBeskrivelse.Text.Replace("\r\n", "<br>");
                String redigertSamarbeidspartere = txtSamarbeidspartnere.Text.Replace("\r\n", "<br>");

                valgtKurs.Kursnavn = txtKursnavn.Text;
                valgtKurs.Beskrivelse = redigertKursBeskrivelse;
                valgtKurs.Påmeldingsfrist = Convert.ToDateTime(txtPåmeldingsfrist.Text + " 00:00:00");
                valgtKurs.Startdato = Convert.ToDateTime(txtStartdato.Text + " 00:00:00");
                valgtKurs.Sluttdato = Convert.ToDateTime(txtSluttdato.Text + " 00:00:00");
                valgtKurs.Målgruppe = ddlMålgruppe.SelectedValue;
                valgtKurs.MaxAntallDeltakere = Convert.ToInt32(txtMaksAntallDeltakere.Text);
                valgtKurs.Tilleggsinformasjon = txtTilleggsInformasjon.Text;
                valgtKurs.KursAnsvarlig = txtKursansvarlig.Text;
                valgtKurs.Samarbeidspartnere = redigertSamarbeidspartere;

                kobling.SubmitChanges();
                Response.Redirect("KursProfil.aspx?kursID=" + id);
            }
            catch (Exception ex)
            {
                litFeilmelding.Text = ex.Message;
            }
        }
    }

    protected void SlettKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Kurs valgtKurs = (from kurs in kobling.Kurs where kurs.KursID == Convert.ToInt32(id) select kurs).SingleOrDefault();

            //Henter ut alle fremmednøler i tabellene ForeleserPåmelding og Kurspåmelding og lagrer de i en liste.
            List<ForeleserPåmelding> foreleserPåmeldingListe = (from foreleserpåmelding in kobling.ForeleserPåmeldings where foreleserpåmelding.KursID == Convert.ToInt32(id) select foreleserpåmelding).ToList();
            List<KursPåmelding> kursPåmeldingListe = (from kursPåmelding in kobling.KursPåmeldings where kursPåmelding.KursID == Convert.ToInt32(id) select kursPåmelding).ToList();

            //Følgende sletter fremmednøkler
            if (foreleserPåmeldingListe.Count > 0)
            {
                for (int i = 0; i < foreleserPåmeldingListe.Count; i++)
                {
                    ForeleserPåmelding slettes = foreleserPåmeldingListe.ElementAt(i);
                    kobling.ForeleserPåmeldings.DeleteOnSubmit(slettes);
                }
            }

            if (kursPåmeldingListe.Count > 0)
            {
                for (int i = 0; i < kursPåmeldingListe.Count; i++)
                {
                    KursPåmelding slettes = kursPåmeldingListe.ElementAt(i);
                    kobling.KursPåmeldings.DeleteOnSubmit(slettes);
                }
            }

            kobling.Kurs.DeleteOnSubmit(valgtKurs);
            kobling.SubmitChanges();
            Response.Redirect("AdminPanel.aspx");
        }
    }
}