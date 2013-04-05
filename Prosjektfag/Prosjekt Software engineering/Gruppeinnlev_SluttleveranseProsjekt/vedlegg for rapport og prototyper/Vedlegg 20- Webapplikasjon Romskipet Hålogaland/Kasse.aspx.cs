using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;

public partial class Kasse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList handlekurv = (ArrayList)Session["Handlekurv"];
        int antallVarer = handlekurv.Count;

        if (antallVarer == 0)
        {
            pnlKasse.Visible = false;
            litIngenVarer.Text = "<p>Du har ingen varer i handlekurven og kan derfor ikke legge inn en bestilling.</p><a href='Nettbutikk.aspx' class='btnSkjemaKnapp'>Tilbake til nettbutikk</a>";
        }

        HentOrdrer();
    }

    protected void HentOrdrer()
    {
        ArrayList handleKurv = (ArrayList)Session["Handlekurv"];
        StringBuilder sbProduktListe = new StringBuilder();
        int sum = 0;

        sbProduktListe.Append("<table class='tblTabellSkjema'>");

        foreach (String[] ordre in handleKurv)
        {
            sbProduktListe.AppendFormat("<tr><td>{0}</td><tr><td>Pris: {1},-</td></tr></tr>",
                ordre[1],
                ordre[2]
                );
            sum += Convert.ToInt32(ordre[2]);
        }

        lblSum.Text = "<p class='success'>Sum: " + sum + ",-</p>";
        sbProduktListe.Append("</table>");
        litOrdreOppsummering.Text = sbProduktListe.ToString();

    }

    protected void KjøpVarer(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                ArrayList handleKurv = (ArrayList)Session["Handlekurv"];

                foreach (String[] ordre in handleKurv)
                {
                    Ordrelinje nyOrdre = new Ordrelinje
                    {
                        BrukerID = Convert.ToInt32(((String[])Session["BrukerSession"])[0]),
                        ProduktID = Convert.ToInt32(ordre[0]),
                        Leveringsadresse = txtAdresse.Text,
                        Postnummer = txtPostnummer.Text
                    };

                    kobling.Ordrelinjes.InsertOnSubmit(nyOrdre);
                }

                kobling.SubmitChanges();

                for (int i = 0; i < handleKurv.Count; i++)
                {
                    handleKurv.RemoveAt(i);
                }

                Response.Redirect("Kvittering.aspx");
                
            }
        }
        catch (Exception ex)
        {
            litOrdreOppsummering.Text = ex.Message;
        }
    }
}