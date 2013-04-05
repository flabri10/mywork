using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class NyttKurs : System.Web.UI.Page
{
    List<Foreleser> leggTilForeleser;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] == null)
        {
            Response.Redirect("Forside.aspx");
        }

        if (!IsPostBack)
        {     
            FyllForeleserListe(); 
        }

        leggTilForeleser = new List<Foreleser>();
    }
    
    //Denne metoden brukes for å finne den nye kursID'en for å kunne redirecte etter kurset er lagt til
    protected int FinnNyKursID()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Kurs> kursliste = (from kurs in kobling.Kurs select kurs).ToList();
            int kursIDTemp = 999;

            foreach (Kurs kurs in kursliste)
            {
                kursIDTemp = kurs.KursID;
            }

            return kursIDTemp;
        }
    }

    protected void FyllForeleserListe()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                List<Foreleser> foreleserListe = (from forelesere in kobling.Forelesers select forelesere).ToList();

                foreach (var foreleser in foreleserListe)
                {
                    ddlForelesere.Items.Add(Convert.ToString(foreleser.Fornavn + " " + foreleser.Etternavn));
                }
            }

            catch (Exception ex)
            {
                litKursFeilmelding.Text = ex.Message;
            }
        }
    }

    protected void LeggTilForeleser(object sender, EventArgs e)
    {
        try
        {
            String valgtForeleser = Convert.ToString(ddlForelesere.SelectedItem);

            txtValgteForelesere.Text = txtValgteForelesere.Text + "\r\n" + valgtForeleser;

            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Foreleser nyForeleser = (from foreleser in kobling.Forelesers where foreleser.Fornavn + " " + foreleser.Etternavn == valgtForeleser select foreleser).SingleOrDefault();

                leggTilForeleser.Add(nyForeleser);
            }

            ddlForelesere.Items.Remove(valgtForeleser);
        }
        catch (Exception ex)
        {
            litKursFeilmelding.Text = ex.Message;
        }
    }

    protected void LeggTilKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                String redigertKursBeskrivelse = txtKursBeskrivelse.Text.Replace("\r\n", "<br>");
                String redigertSamarbeidsPartnere = txtSamarbeidspartnere.Text.Replace("\r\n", "<br>");
                
                Kurs nyttKurs = new Kurs
                {
                    Kursnavn = txtKursnavn.Text,
                    Beskrivelse = redigertKursBeskrivelse,
                    Påmeldingsfrist = Convert.ToDateTime(txtPåmeldingsfrist.Text + " 00:00:00"),
                    Startdato = Convert.ToDateTime(txtStartdato.Text + " 00:00:00"),
                    Sluttdato = Convert.ToDateTime(txtSluttdato.Text + " 00:00:00"),
                    Målgruppe = ddlMålgruppe.SelectedValue,
                    MaxAntallDeltakere = Convert.ToInt32(txtMaxAntallDeltakere.Text),
                    Tilleggsinformasjon = txtTilleggsInformasjon.Text,
                    KursAnsvarlig = txtKursansvarlig.Text,
                    Samarbeidspartnere = redigertSamarbeidsPartnere
                };

                kobling.Kurs.InsertOnSubmit(nyttKurs);
                kobling.SubmitChanges();

                foreach (Foreleser nyForeleser in leggTilForeleser)
                {
                    ForeleserPåmelding nyForeleserPåmelding = new ForeleserPåmelding
                    {
                        ForeleserID = nyForeleser.ForeleserID,
                        KursID = FinnNyKursID()
                    };

                    kobling.ForeleserPåmeldings.InsertOnSubmit(nyForeleserPåmelding);
                }

                kobling.SubmitChanges();
                Response.Redirect("AdminPanel.aspx");
            }
            catch (Exception ex)
            {
                litKursFeilmelding.Text = ex.Message;
            }
        }
    }
}