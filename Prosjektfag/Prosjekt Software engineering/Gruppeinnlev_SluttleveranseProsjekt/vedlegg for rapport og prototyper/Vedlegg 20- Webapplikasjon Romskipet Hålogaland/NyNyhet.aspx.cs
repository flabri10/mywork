using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class NyNyhet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] == null)
        {
            Response.Redirect("Forside.aspx");
        }
    }

    protected void LeggTilNyhet(object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            try
            {
                if (fuNyhetsBilde.HasFile)
                {
                    System.Drawing.Image filobjekt = System.Drawing.Image.FromStream(fuNyhetsBilde.PostedFile.InputStream);

                    System.Drawing.Image redigertBilde = new Bitmap(filobjekt, (180), (120));
                    redigertBilde.Save(Server.MapPath("img/AktueltBilder/aktuelt_") + txtNyhetsTittel.Text + ".jpg");
                }

                String redigertBrødTekst = txtNyhetsBrødtekst.Text.Replace("\r\n", "<br>");
                String redigertIngress = txtNyhetsIngress.Text.Replace("\r\n", "<br>");

                Nyhet nyNyhet = new Nyhet
                {
                    Dato = Convert.ToString(DateTime.Now.ToShortDateString()),
                    Tittel = txtNyhetsTittel.Text,
                    Ingress = redigertIngress,
                    Brødtekst = redigertBrødTekst,
                    Bildetittel = "aktuelt_" + txtNyhetsTittel.Text
                };

                kobling.Nyhets.InsertOnSubmit(nyNyhet);
                kobling.SubmitChanges();
            }
            catch (Exception ex)
            {
                litNyhetFeilmelding.Text = ex.Message;
            }
        }

        Response.Redirect("AdminPanel.aspx");
    }
}