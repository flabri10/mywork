using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;
using System.Text;

public partial class LeggTilBilde : System.Web.UI.Page
{
    int innloggetBruker;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void VisFilinfo(object sender, EventArgs e)
    {
        StringBuilder str = new StringBuilder();
        str.AppendFormat("<u>Fil: {0}</u><br/>", fuFil.FileName);

        if (fuFil.HasFile)
        {
            try
            {
                Stream stream = fuFil.FileContent;
                StreamReader leser = new StreamReader(stream);
                string strLinje = "";

                do
                {
                    strLinje = leser.ReadLine();
                    str.Append(strLinje);
                } while (strLinje != null);
            }
            catch (Exception ex)
            {
                str.Append("<br/><b>Feil</b><br/>");
                str.AppendFormat("Kunne ikke vise {}<br/>{1}", fuFil.FileName, ex.Message);
            }
        }
        else
        {
            litFilinfo.Text = "Ingen fil ble lastet opp.";
        }

        litFilinfo.Text = str.ToString();
        lblFilStatus.Text = "";
    }

    protected void LastOppFil(object sender, EventArgs e)
    {
        StringBuilder str = new StringBuilder();
        String filsti = Server.MapPath("Bilder//");

        if (fuFil.HasFile)
        {
            try
            {
                str.AppendFormat("Laster opp fil: {0}", fuFil.FileName);

                fuFil.SaveAs(filsti + "" + fuFil.FileName);

                str.AppendFormat("<br/> Lagret som: {0}", fuFil.PostedFile.FileName);
                str.AppendFormat("<br/> Filtype: {0}", fuFil.PostedFile.ContentType);
                str.AppendFormat("<br/> Filstørrelse(bytes): {0}", fuFil.PostedFile.ContentLength);
                str.AppendFormat("<br/> Filnavn: {0}", fuFil.PostedFile.FileName);

                lblFilStatus.Text = "Filen ble lagret.";
                LeggBildeITabell();
            }
            catch (Exception ex)
            {
                str.Append("<br/><b>Det oppstod en feil ved lagringen av filen.</b><br/>");
                str.AppendFormat("Kunne ikke lagre {0}{1}", filsti, fuFil.FileName, ex.Message);
            }
        }
        else
        {
            lblFilStatus.Text = "Filen ble ikke lastet opp.";
        }

        litFilinfo.Text = str.ToString();
        lblFilStatus.Text = "";
    }

    protected void LeggBildeITabell()
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
        {
            String Tittel = txtTittel.Text;
            SjekkSessions();
            Bilde nyttBilde = new Bilde
            {
                Tittel = txtTittel.Text,
                Bildenavn = txtBildenavn.Text,
                BrukerId = innloggetBruker
            };

            kobling.Bildes.InsertOnSubmit(nyttBilde);
            kobling.SubmitChanges();
            kobling.Connection.Close();
        }
    }

    protected void SjekkSessions()
    {
        if (Session["BrukerSession"] != null)
        {
            int innloggetBruker = ((int[])Session["BrukerSession"])[2];
        }
        else
        {
            Response.Redirect("Logginn.aspx");
        }
    }
}