//Innlevering 3 Webdesign 1 kodet av Britt-Heidi Fladby-Flabri10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Oppg3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SjekkKnapp(object sender, EventArgs e)
    {
        Button knapp = (Button)sender;
        String knappensId = knapp.ID;
    }

    protected void VisHundebilder(object sender, EventArgs e)
    {
        String htmlStreng = "";
        htmlStreng += "<img src='hund1.jpg' alt='Hund 1' class='bilder'/>";
        htmlStreng += "<img src='hund2.jpg' alt='Hund 2' class='bilder'/>";
        htmlStreng += "<img src='hund3.jpg' alt='Hund 3' class='bilder'/>";
        
        litBildeserie.Text = htmlStreng;
    }

    protected void VisKattebilder(object sender, EventArgs e)
    {
        String htmlStreng = "";
        htmlStreng += "<img src='katt1.jpg' alt='Katt 1' class='bilder'/>";
        htmlStreng += "<img src='katt2.jpg' alt='Katt 2' class='bilder'/>";
        htmlStreng += "<img src='katt3.jpg' alt='Katt 3' class='bilder'/>";

        litBildeserie.Text = htmlStreng;
    }
}