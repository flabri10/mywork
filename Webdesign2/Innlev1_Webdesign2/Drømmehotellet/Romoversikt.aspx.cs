using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text;

public partial class Romoversikt : System.Web.UI.Page
{
    String filsti;
    XElement xmlRom;

    protected void Page_Load(object sender, EventArgs e)
    {
        filsti = Server.MapPath("Xmlfiler/rom.xml");

        if (!IsPostBack)
        {
            FyllRomoversikt();
        }
    }

    protected void FyllRomoversikt()
    {
        XElement xmlRom = XElement.Load(filsti);

        var romOversikt = from romliste in xmlRom.Descendants("rom") select romliste;

        StringBuilder sbRom = new StringBuilder();
        
        foreach (var rom in romOversikt)
        {
            sbRom.AppendFormat("<h3>{0}</h3> <ul><li>{1}</li> <li>Pris: {2}</li> <li>Status: {3}</li></ul>", 
                                (String)rom.Element("tema"), 
                                (String)rom.Element("tilstand"), 
                                (String)rom.Element("pris"), 
                                (String)rom.Element("ledig"));

        }

        litRomoversikt.Text = sbRom.ToString();
    }
}
