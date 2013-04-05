//Innlevering 3 Webdesign 1 kodet av Britt-Heidi Fladby-Flabri10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Oppg1_side1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Oppdater(object sender, EventArgs e)
    {
        gvMelodier.DataBind();
    }
}