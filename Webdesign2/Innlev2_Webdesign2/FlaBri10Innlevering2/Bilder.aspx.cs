using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Bilder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        VisBildeliste();
    }

    protected void VisBildeliste()
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
        {
            try
            {
                var bildeliste = from bilder in kobling.Bildes
                                     select bilder;

                StringBuilder sbBildeliste = new StringBuilder();

                sbBildeliste.Append("<ul>");

                foreach (var bilde in bildeliste)
                {
                    sbBildeliste.AppendFormat("<li><h3>{0}</h3><img src='Bilder/{1}' alt='{0}'/><a href='BildeMedKommentar.aspx?bildeId={3}' alt='{0}'>Se kommentarer</a></li>",
                        bilde.Tittel,
                        bilde.Bildenavn,
                        bilde.KommentarId,
                        bilde.BildeId);
                }
                
                sbBildeliste.Append("</ul>");

                litBildeliste.Text = sbBildeliste.ToString();
            }
            catch (Exception ex)
            {
                litBildeliste.Text = ex.Message;
            }
        }
    }
}