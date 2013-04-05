using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AktueltProfil : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("NyhetsID");
        FyllAktueltProfil(id);
        
    }

    protected void FyllAktueltProfil(String id)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                Nyhet valgtNyhet = (from nyhet in kobling.Nyhets where nyhet.NyhetsID == Convert.ToInt32(id) select nyhet).SingleOrDefault();

                String redigertIngress = valgtNyhet.Ingress.Replace("<\r\n", "<br>");

                litNyhetsTittel.Text = valgtNyhet.Tittel;
                litNyhetsIngress.Text = redigertIngress;
                litBrødtekst.Text = valgtNyhet.Brødtekst;

            }
            catch (Exception ex)
            {
                litNyhetsTittel.Text = "Denne nyheten finnes ikke";
            }
               
        }
    }
}