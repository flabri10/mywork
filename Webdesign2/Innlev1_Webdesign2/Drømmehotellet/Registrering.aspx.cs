using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class Registrering : System.Web.UI.Page
{
    int kundeId;
    bool status;
    String ledig;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FyllDropDownRomliste();
        }
    }

    protected void FyllDropDownRomliste()
    {
        XElement xmlRom = XElement.Load(Server.MapPath("Xmlfiler/rom.xml"));

        var romliste = from romoversikt in xmlRom.Descendants("rom")
                       select romoversikt;

        foreach (var rom in romliste)
        {
            ddlRom.Items.Add(new ListItem((String)rom.Element("tema")));
        }    
    }

    protected void RegistrerKunde(object sender, EventArgs e)
    {
        XElement xmlKunde = XElement.Load(Server.MapPath("Xmlfiler/kunde.xml"));
        //generererkundeId();
        
        kundeId= 0;
        kundeId++;
        xmlKunde.Add(new XElement("kunde", new XElement("fornavn", txtFornavn.Text),
                                           new XElement("etternavn", txtEtternavn.Text),
                                           new XElement("mobil", txtMobil.Text),
                                           new XElement("epost", txtEpost.Text),
                                           new XElement("kundeId", kundeId),
                                           new XElement("kundeId", ledig)
                                 )
                    );

        //if rom er valgt, er det ikke ledig. String ledig endres til "opptatt av" + kundeId
        //else rommet er ledig

        XElement xmlRom = XElement.Load(Server.MapPath("Xmlfiler/rom.xml"));
        xmlRom.Add(new XElement("rom", new XElement("ledig", ddlRom))); 
        
        litRegTilbakemelding.Text = "Kunde registrert!";
        xmlKunde.Save(Server.MapPath("Xmlfiler/kunde.xml"));
        
        Response.Redirect(Request.Url.ToString());
    }
    
    //protected int genererKundeId()
    
        //genererer kundeId ved bruk av array

    protected void ddlRom_SelectedIndexChanged(object sender, EventArgs e)
    {
        String ledig = "ledig";
        
        //når rom er valgt settes string til "ikke ledig"
    }
}
