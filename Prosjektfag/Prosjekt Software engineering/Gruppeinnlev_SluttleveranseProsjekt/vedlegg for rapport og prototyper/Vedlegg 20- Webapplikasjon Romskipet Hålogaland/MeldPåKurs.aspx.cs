using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MeldPåKurs : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("kursID");
        FyllKursNavn();

        if (Session["BrukerSession"] == null)
        {
            litFeilmelding.Text = "Du må være logget inn som bruker for å melde deg på dette kurset. <a href='LoggInn.aspx' class='lesMer'>Trykk her for å logge inn </a>";
            pnlMeldPåKurs.Visible = false;

        }

        else
        {
            litBrukerInfo.Text = "Du er logget inn som " + ((String[])Session["BrukerSession"])[3] + " " + ((String[])Session["BrukerSession"])[4] + ".<br/> ";
        }
    }

    protected void FyllKursNavn()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Kurs valgtKurs = (from kurs in kobling.Kurs where kurs.KursID == Convert.ToInt32(id) select kurs).SingleOrDefault();
            litKursNavn.Text = valgtKurs.Kursnavn;
        }
    }

    protected void _MeldPåKurs(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Kurs valgtKurs = (from kurs in kobling.Kurs where kurs.KursID == Convert.ToInt32(id) select kurs).SingleOrDefault();
            Bruker loggetInnBruker = (from bruker in kobling.Brukers where bruker.BrukerID == Convert.ToInt32(((String[])Session["BrukerSession"])[0]) select bruker).SingleOrDefault();
            KursPåmelding valgtKursPåmelding = (from kurspåmelding in kobling.KursPåmeldings where kurspåmelding.BrukerID == loggetInnBruker.BrukerID && valgtKurs.KursID == kurspåmelding.KursID select kurspåmelding).SingleOrDefault();

            if (valgtKursPåmelding != null)
            {
                litFeilmelding.Text = "Du er allerede meldt på dette kurset. <a href='KursProfil.aspx?kursID=" + id +"' class='lesMer'>Tilbake til kurs</a>";
            }

            else {

                KursPåmelding nyKursPåmelding = new KursPåmelding
                {
                    KursID = valgtKurs.KursID,
                    BrukerID = Convert.ToInt32(((String[])Session["BrukerSession"])[0])
                };

                kobling.KursPåmeldings.InsertOnSubmit(nyKursPåmelding);
                kobling.SubmitChanges();
                Session["PåmeldingSuksess"] = "<img src='gfx/success.png' alt='Suksess' class='imgNoStyle'/>Påmeldingen var vellykket";
                Response.Redirect("KursProfil.aspx?kursID=" + id);
            }

        }
    }
}