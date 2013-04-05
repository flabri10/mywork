using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NyttProdukt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdministratorSession"] == null)
        {
            Response.Redirect("Forside.aspx");
        }
    }

    protected void LagreProdukt(object sender, EventArgs e)
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                
                String filsti = Server.MapPath("img/Nettbutikk/");
                String bildenavn = fuBilde.FileName;

                fuBilde.SaveAs(filsti + bildenavn);

                Produkt nyttProdukt = new Produkt
                {
                    ProduktNavn = txtProduktNavn.Text,
                    Pris = Convert.ToInt32(txtPris.Text),
                    Beskrivelse = txtProduktBeskrivelse.Text,
                    Bilde = fuBilde.FileName
                };


                kobling.Produkts.InsertOnSubmit(nyttProdukt);
                kobling.SubmitChanges();
            }

            Response.Redirect("AdminPanel.aspx");
        }
        catch (Exception ex)
        {
            lblStatus.Text = ex.Message;
        }
    }
}