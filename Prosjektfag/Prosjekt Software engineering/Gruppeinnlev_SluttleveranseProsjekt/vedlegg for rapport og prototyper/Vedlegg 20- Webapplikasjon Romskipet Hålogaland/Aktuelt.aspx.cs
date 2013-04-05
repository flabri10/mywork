using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Aktuelt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FyllNyheter();
    }

    protected void FyllNyheter()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                List<Nyhet> nyhetsliste = (from nyheter in kobling.Nyhets orderby nyheter.NyhetsID descending select nyheter).ToList();

                StringBuilder sbNyhetsListe = new StringBuilder();

                foreach (var nyhet in nyhetsliste)
                {
                    sbNyhetsListe.AppendFormat("<div id='aktueltContainer'> <img src='img/AktueltBilder/{2}.jpg'> <h3>{0}</h3> <p>{1}</p> <a href='AktueltProfil.aspx?NyhetsID={4}'>Les mer</a><span class='date'>{3}</p></div>",
                        nyhet.Tittel,
                        nyhet.Ingress,
                        nyhet.Bildetittel,
                        nyhet.Dato,
                        nyhet.NyhetsID);
                }

                litAktueltliste.Text = sbNyhetsListe.ToString();
            }
            catch (Exception ex)
            {
                litAktueltliste.Text = ex.Message;
            }
        }
    }
}