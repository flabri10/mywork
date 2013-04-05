using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class RedigerNyhet : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("NyhetID");
        if (!IsPostBack)
        {
            FyllNyhetInfo();
        }
        
    }

    protected void FyllNyhetInfo()
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Nyhet valgtNyhet = (from nyhet in kobling.Nyhets where nyhet.NyhetsID == Convert.ToInt32(id) select nyhet).SingleOrDefault();

                String redigertBrødtekst = valgtNyhet.Brødtekst.Replace("<br>", "\r\n");
                String redigertIngress = valgtNyhet.Ingress.Replace("<br>", "\r\n");

                txtNyhetsTittel.Text = valgtNyhet.Tittel;
                txtNyhetsIngress.Text = redigertIngress;
                txtNyhetsBrødtekst.Text = redigertBrødtekst;
            }
        }

        catch (Exception ex)
        {
            litNyhetFeilmelding.Text = "Denne nyheten finnes ikke";
        }
    }

    protected void LagreEndringer(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Nyhet valgtNyhet = (from nyhet in kobling.Nyhets where nyhet.NyhetsID == Convert.ToInt32(id) select nyhet).SingleOrDefault();

                String redigertIngress = txtNyhetsIngress.Text.Replace("\r\n", "<br>");
                String redigertBrødtekst = txtNyhetsBrødtekst.Text.Replace("\r\n", "<br>");

                if (fuNyhetsBilde.HasFile)
                {
                    System.Drawing.Image filobjekt = System.Drawing.Image.FromStream(fuNyhetsBilde.PostedFile.InputStream);

                    System.Drawing.Image redigertBilde = new Bitmap(filobjekt, (180), (120));
                    redigertBilde.Save(Server.MapPath("img/AktueltBilder/aktuelt_") + txtNyhetsTittel.Text + ".jpg");
                }

                valgtNyhet.Tittel = txtNyhetsTittel.Text;
                valgtNyhet.Ingress = redigertIngress;
                valgtNyhet.Brødtekst = redigertBrødtekst;
                valgtNyhet.Bildetittel = "aktuelt_" + txtNyhetsTittel.Text;

                kobling.SubmitChanges();

            }

            Response.Redirect("AktueltProfil.aspx?NyhetsID="+id);
        }
        catch (Exception ex)
        {
            litNyhetFeilmelding.Text = ex.Message;
        }
    }

    protected void SlettNyhet(Object sender, EventArgs e)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            Nyhet valgtNyhet = (from nyhet in kobling.Nyhets where nyhet.NyhetsID == Convert.ToInt32(id) select nyhet).SingleOrDefault();

            kobling.Nyhets.DeleteOnSubmit(valgtNyhet);
            kobling.SubmitChanges();
        }
        Response.Redirect("AdminPanel.aspx");
    }
}