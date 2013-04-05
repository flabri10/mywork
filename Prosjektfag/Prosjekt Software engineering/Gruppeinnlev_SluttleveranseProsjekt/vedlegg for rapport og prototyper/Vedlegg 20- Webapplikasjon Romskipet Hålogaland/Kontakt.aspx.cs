using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kontakt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SendMelding(object sender, EventArgs e)
    {
        litSendTilbakemelding.Text = "<p class='success'><img src='gfx/success.png' class='imgNoStyle' alt='Suksess'/>Meldingen er sendt!</p>";
    }
}