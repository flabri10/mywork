using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MeldPåAktivitet : System.Web.UI.Page
{

    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("AktivitetID");
        FyllAktivitetNavn();

        if (Session["BrukerSession"] == null)
        {
            litFeilmelding.Text = "Du må være logget inn som bruker for å melde deg på dette kurset. <a href='LoggInn.aspx' class='lesMer'>Trykk her for å logge inn </a>";
            pnlMeldPåAktivitet.Visible = false;

        }

        else
        {
            litBrukerInfo.Text = "Du er logget inn som " + ((String[])Session["BrukerSession"])[3] + " " + ((String[])Session["BrukerSession"])[4] + ".<br/> ";
        }

    }

    protected void FyllAktivitetNavn()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Aktivitet valgtAktivitet = (from aktivitet in kobling.Aktivitets where aktivitet.AktivitetID == Convert.ToInt32(id) select aktivitet).SingleOrDefault();
           


            litAktivitetNavn.Text = valgtAktivitet.AktivitetNavn;
        }
    }

    protected void _MeldPåAktivitet(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Aktivitet valgtAktivitet = (from aktivitet in kobling.Aktivitets where aktivitet.AktivitetID == Convert.ToInt32(id) select aktivitet).SingleOrDefault();
            Bruker loggetInnBruker = (from bruker in kobling.Brukers where bruker.BrukerID == Convert.ToInt32(((String[])Session["BrukerSession"])[0]) select bruker).SingleOrDefault();

            AktivitetPåmelding valgtAktivitetPåmelding = (from aktivitetPåmelding in kobling.AktivitetPåmeldings where aktivitetPåmelding.BrukerID == loggetInnBruker.BrukerID && valgtAktivitet.AktivitetID == aktivitetPåmelding.AktivitetID select aktivitetPåmelding).SingleOrDefault();

            if (valgtAktivitetPåmelding != null)
            {
                litFeilmelding.Text = "<p class='failure'>Du er allerede meldt på denne aktiviteten</p>";
            }
            else
            {
                AktivitetPåmelding nyAktivitetPåmelding = new AktivitetPåmelding
                {
                    AktivitetID = valgtAktivitet.AktivitetID,
                    BrukerID = Convert.ToInt32(((String[])Session["BrukerSession"])[0])
                };

                kobling.AktivitetPåmeldings.InsertOnSubmit(nyAktivitetPåmelding);
                kobling.SubmitChanges();

                Session["PåmeldingSuksess"] = "<img src='gfx/success.png' alt='Suksess' class='imgNoStyle'/>Påmeldingen var vellykket";
                Response.Redirect("AktivitetProfil.aspx?AktivitetID=" + id);
            }

        }
    }
}