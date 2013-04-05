using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections;

public partial class Handlekurv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList handlekurv = (ArrayList)Session["Handlekurv"];
        int antallVarer = handlekurv.Count;

        if (antallVarer == 0)
        {
            pnlHandlekurv.Visible = false;
        }
              
        HentVarer();
    }

    protected void HentVarer()
    {
        ArrayList handleKurv = (ArrayList)Session["Handlekurv"];
        StringBuilder sbProduktListe = new StringBuilder();
        int sum = 0;

        sbProduktListe.Append("<table id='tblHandlekurv'><tr class='handleKurvHead'><td></td><td>Produktbeskrivelse</td><td>Pris</td><td>Fjern vare</td></tr>");

        foreach (String[] ordre in handleKurv)
        {
            sbProduktListe.AppendFormat("<tr><td><img src='img/Nettbutikk/{3}'/></td><td><h3>{0}</h3><p>{4}</p></td><td><p>{1},-</p></td><td class='last'><a href='FjernFraHandleKurv.aspx?ProduktID={2}'><img src='gfx/lukk.png' class='imgNoStyle'></a></td></tr>",
                ordre[1],
                ordre[2],
                ordre[0],
                ordre[3],
                ordre[4]
                );
            sum += Convert.ToInt32(ordre[2]);
        }

        sbProduktListe.Append("</table>");
        lbAntallVarer.Text = Convert.ToString(handleKurv.Count);
        litProduktListe.Text = sbProduktListe.ToString();
        litProduktSum.Text = Convert.ToString(sum) + ",-";
    }
}