using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RedigerProdukt : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("ProduktID");

        if (!IsPostBack)
        {
            HentProdukt();
        }
        
    }

    protected void HentProdukt()
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Produkt valgtProdukt = (from produkt in kobling.Produkts where produkt.ProduktID == Convert.ToInt32(id) select produkt).SingleOrDefault();

                txtProduktNavn.Text = valgtProdukt.ProduktNavn;
                txtProduktBeskrivelse.Text = valgtProdukt.Beskrivelse;
                txtPris.Text = Convert.ToString(valgtProdukt.Pris);

            }
        }
        catch (Exception ex)
        {
            litProduktFeilmelding.Text = "<p class='failure'>Dette produktet finnes ikke</p>";
        }
    }

    protected void LagreEndringer(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Produkt valgtProdukt = (from produkt in kobling.Produkts where produkt.ProduktID == Convert.ToInt32(id) select produkt).SingleOrDefault();

                valgtProdukt.ProduktNavn = txtProduktNavn.Text;
                valgtProdukt.Beskrivelse = txtProduktBeskrivelse.Text;
                valgtProdukt.Pris = Convert.ToDecimal(txtPris.Text);

                if (fuBilde.HasFile)
                {
                    String filsti = Server.MapPath("img/Nettbutikk/");
                    String bildenavn = fuBilde.FileName;
                    fuBilde.SaveAs(filsti + bildenavn);
                    valgtProdukt.Bilde = fuBilde.FileName;
                }
                
                kobling.SubmitChanges();
                Response.Redirect("AdminPanel.aspx");
            }
        }
        catch (Exception ex)
        {
            litProduktFeilmelding.Text = ex.Message;
        }
    }

    protected void SlettProdukt(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Produkt valgtProdukt = (from produkt in kobling.Produkts where produkt.ProduktID == Convert.ToInt32(id) select produkt).SingleOrDefault();

                kobling.Produkts.DeleteOnSubmit(valgtProdukt);
                kobling.SubmitChanges();
                Response.Redirect("AdminPanel.aspx");
            }

        }
        catch (Exception ex)
        {
            litProduktFeilmelding.Text = ex.Message;
        }

        
    }
}