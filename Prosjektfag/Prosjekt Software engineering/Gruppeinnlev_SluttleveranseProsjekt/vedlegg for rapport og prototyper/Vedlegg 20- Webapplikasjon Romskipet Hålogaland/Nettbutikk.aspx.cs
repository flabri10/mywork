using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections;

public partial class Nettbutikk : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        VisProduktliste();
        if (Request.QueryString["ProduktID"] != null)
        {
            LeggTilIHandlekurv(Request.QueryString["ProduktID"]);
        }

        if (Session["Handlekurv"] == null)
        {
            Session["Handlekurv"] = new ArrayList();
            lblAntallVarer.Text = " " + 0; 
        }
        else
        {
            ArrayList handlekurv = (ArrayList)  Session["Handlekurv"];
            int antallVarer = handlekurv.Count;
            lblAntallVarer.Text = " " + antallVarer;
        }
        SjekkSession();
    }

    protected void VisProduktliste()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            var produktliste = from produkter in kobling.Produkts select produkter;

            StringBuilder sbProduktliste = new StringBuilder();

            foreach (var produkt in produktliste)
            {
                sbProduktliste.AppendFormat
                    ("<div class='divProduktBoks'><h3>{0}</h3><img src='img/Nettbutikk/{1}' class='produktBilder' alt='Bilde av produkt'/><p>{2}</p><p class='pPris'>{3},-</p><a href='Nettbutikk.aspx?ProduktID={4}' class='btnSkjemaKnappNettbutikk'>Legg til i handlekurv</a></div>",
                                                produkt.ProduktNavn,
                                                produkt.Bilde,
                                                produkt.Beskrivelse,
                                                produkt.Pris,
                                                produkt.ProduktID
                    );
            }

            if (Session["LeggTilError"] != null)
            {
                litKjøpTilbamelding.Text = (String)Session["LeggTilError"];
                Session.Remove("LeggTilError");
            }

            litProduktliste.Text = sbProduktliste.ToString();
        }
    }

    protected void LeggTilIHandlekurv(String produktID)
    {
        if (Session["BrukerSession"] == null)
        {
            litKjøpTilbamelding.Text = "Du må være logget inn som vanlig bruker for å gjøre dette. <a href='LoggInn.aspx' class='lesMer'>Trykk her for å logge inn.</a>";
        }
        else
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Produkt valgtProdukt = (from produkt in kobling.Produkts where produkt.ProduktID == Convert.ToInt32(produktID) select produkt).SingleOrDefault();

                if (valgtProdukt == null)
                {
                    return;
                }

                ArrayList handlekurv = (ArrayList)Session["Handlekurv"];
                handlekurv.Add(new String[] { Convert.ToString(valgtProdukt.ProduktID), valgtProdukt.ProduktNavn, Convert.ToString(valgtProdukt.Pris), valgtProdukt.Bilde, valgtProdukt.Beskrivelse});
                Session["Handlekurv"] = handlekurv;
                Response.Redirect("Nettbutikk.aspx");
            }
        }
    }

    protected void SjekkSession()
    {
        if (Session["KjøpFullført"] != null)
        {
            litKjøpTilbamelding.Text = (String)Session["KjøpFullført"];
            Session.Remove("KjøpFullført");
        }
    }
}