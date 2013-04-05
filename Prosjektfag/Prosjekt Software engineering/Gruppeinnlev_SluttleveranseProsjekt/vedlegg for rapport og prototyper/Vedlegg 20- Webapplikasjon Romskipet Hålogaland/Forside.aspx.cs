using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Forside : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Fyllnyhetsfeed();
    }

    protected void Fyllnyhetsfeed()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                List<Nyhet> nyhetsliste = (from nyheter in kobling.Nyhets select nyheter).ToList();
                int antallNyheter = nyhetsliste.Count;

                int maxAntallTegn = 170;

                Nyhet nyhet1 = nyhetsliste.ElementAt(antallNyheter-1);
                litNyhetsTittel_1.Text = nyhet1.Tittel;

                char[] splitArray1 = nyhet1.Ingress.ToCharArray();

                String nyIngress1 = "";

                for (int i = 0; i < maxAntallTegn; i++)
                {
                    nyIngress1 += splitArray1[i];
                }

                nyIngress1 += " [...]";

                litNyhetsIngress_1.Text = nyIngress1;
                litLinkNyhet1.Text = "<a href='AktueltProfil.aspx?NyhetsID=" + nyhet1.NyhetsID + "' class='lesMer'>Les mer </a>";

                Nyhet nyhet2 = nyhetsliste.ElementAt(antallNyheter - 2);
                litNyhetsTittel_2.Text = nyhet2.Tittel;

                char[] splitArray2 = nyhet2.Ingress.ToCharArray();

                String nyIngress2 = "";

                for (int i = 0; i < maxAntallTegn; i++)
                {
                    nyIngress2 += splitArray2[i];
                }

                nyIngress2 += " [...]";

                litNyhetsIngress_2.Text = nyIngress2;
                litLinkNyhet2.Text = "<a href='AktueltProfil.aspx?NyhetsID=" + nyhet2.NyhetsID + "' class='lesMer'>Les mer </a>";   
            }
            catch (Exception ex)
            {
                litNyhetsIngress_1.Text = ex.Message;
            }
        }
    }
}