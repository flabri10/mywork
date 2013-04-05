using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NyAktivitet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] == null)
        {
            Response.Redirect("Forside.aspx");
        }
    }

    protected void LeggTilAktivitet(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Aktivitet nyAktivitet = new Aktivitet
                {
                    AktivitetNavn = txtAktivitetNavn.Text,
                    Beskrivelse = txtAktivitetBeskrivelse.Text,
                    Startdato = Convert.ToDateTime(txtStartdato.Text + " 00:00:00"),
                    Sluttdato = Convert.ToDateTime(txtSluttdato.Text + " 00:00:00"),
                    StartTidspunkt = txtStartTidspunkt.Text,
                    SluttTidspunkt = txtSluttTidspunkt.Text,
                };

                kobling.Aktivitets.InsertOnSubmit(nyAktivitet);
                kobling.SubmitChanges();

                Response.Redirect("AdminPanel.aspx");
            }
        }
        catch (Exception ex)
        {

        }
    }
}