using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RedigerAktivitet : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("AktivitetID");
        if (!IsPostBack)
        {
            HentAktivitet();
        }
    }

    protected void HentAktivitet()
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Aktivitet valgtAktivitet = (from aktivitet in kobling.Aktivitets where aktivitet.AktivitetID == Convert.ToInt32(id) select aktivitet).SingleOrDefault();

                txtAktivitetNavn.Text = valgtAktivitet.AktivitetNavn;
                txtAktivitetBeskrivelse.Text = valgtAktivitet.Beskrivelse;
                txtStartdato.Text = valgtAktivitet.Startdato.ToShortDateString();
                txtSluttdato.Text = valgtAktivitet.Sluttdato.ToShortDateString();
                txtStartTidspunkt.Text = valgtAktivitet.StartTidspunkt;
                txtSluttTidspunkt.Text = valgtAktivitet.SluttTidspunkt;
            }
        }

        catch (Exception ex)
        {
            litAktivitetFeilmelding.Text = "<p class='failure'>Denne aktiviteten finnes ikke.</p>";
        }
    }

    protected void LagreEndringer(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Aktivitet valgtAktivitet = (from aktivitet in kobling.Aktivitets where aktivitet.AktivitetID == Convert.ToInt32(id) select aktivitet).SingleOrDefault();

                valgtAktivitet.AktivitetNavn = txtAktivitetNavn.Text;
                valgtAktivitet.Beskrivelse = txtAktivitetBeskrivelse.Text;
                valgtAktivitet.Startdato = Convert.ToDateTime(txtStartdato.Text + " 00:00:00");
                valgtAktivitet.Sluttdato = Convert.ToDateTime(txtSluttdato.Text + " 00:00:00");
                valgtAktivitet.StartTidspunkt = txtStartTidspunkt.Text;
                valgtAktivitet.SluttTidspunkt = txtSluttTidspunkt.Text;

                kobling.SubmitChanges();
                Response.Redirect("AdminPanel.aspx");
            }
        }
        catch (Exception ex)
        {
            litAktivitetFeilmelding.Text = ex.Message;
        }
    }

    protected void SlettAktivitet(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Aktivitet valgtAktivitet = (from aktivitet in kobling.Aktivitets where aktivitet.AktivitetID == Convert.ToInt32(id) select aktivitet).SingleOrDefault();

                //Henter ut fremmednøklene i AktivitetPåmelding og lagrer de i en liste
                List<AktivitetPåmelding> aktivitetPåmeldingListe = (from aktivitetPåmeldinger in kobling.AktivitetPåmeldings where aktivitetPåmeldinger.AktivitetID == Convert.ToInt32(id) select aktivitetPåmeldinger).ToList();

                //Sletter alle fremmednøkler
                for (int i = 0; i < aktivitetPåmeldingListe.Count; i++)
                {
                    AktivitetPåmelding slettes = aktivitetPåmeldingListe.ElementAt(i);
                    kobling.AktivitetPåmeldings.DeleteOnSubmit(slettes);
                }

                kobling.Aktivitets.DeleteOnSubmit(valgtAktivitet);
                kobling.SubmitChanges();

                Response.Redirect("AdminPanel.aspx");
            }
        }
        catch (Exception ex)
        {
            litAktivitetFeilmelding.Text = ex.Message;
        }
    }
}