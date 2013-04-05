using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Media : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        genererBilder();
    }

    protected void genererBilder()
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {

            List<Bilder> bildeListe = (from bilde in kobling.Bilders
                                      select bilde).ToList();

            StringBuilder sbUtskrift = new StringBuilder();

            sbUtskrift.AppendFormat("");

            foreach (Bilder bilde in bildeListe)
            {
                sbUtskrift.AppendFormat("<img class='imgBildeliste' src='{0}' alt='{1}' />",
                    bilde.Path,
                    bilde.Bildenavn

                    );
            }

            sbUtskrift.AppendFormat("");

            litUtskrift.Text = sbUtskrift.ToString();
        }
    }
}