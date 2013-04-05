using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Oppg1MasterPage : System.Web.UI.MasterPage
{
    private String statusTekst;
    private String statusFarge;
    private ListItem item;
    private RadioButtonList rblListe;

    protected void Page_Load(object sender, EventArgs e)
    {
        FyllFarger();
        VisStatus();
        if (!IsPostBack)
        {
            Response.Redirect("Oppg2_side2.aspx");
        }
    }

    protected void FyllFarger()
    {
        string[] fargeArray = { "red", "blue", "yellow", "green" };

        for (int i = 0; i < fargeArray.Length; i++)
        {
            ListItem item = new ListItem(fargeArray[i]);
            rblListe.Items.Add(item);
        }
    }

    //knapper
    protected void btnLagreSession_Click(object sender, EventArgs e)
    {
        Navn = navn;
        Farge = statusFarge;
    }

    protected void btnTilSide2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Oppg2_side2.aspx");
    }

    protected void btnSlettSession_Click(object sender, EventArgs e)
    {
        Session["Navn"] = null;
        Session["Farge"] = null;
    }

    protected void VisStatus()
    {
        String statusTekst;
        String statusFarge;
        String navn = txtNavn.Text;
        String status2 = lblStatus2.Text;
        statusFarge = rblListe.SelectedItem.Text;

        if (navn != null)
        {
            Navn = navn;
            statusTekst = "Session lagret. Navn: " + Navn + ". Farge: " + statusFarge;
            status2 = "Session lagret. Navn: " + Navn + ". Farge: " + statusFarge;
        }
        else
        {
            statusTekst = "Ingen session lagret";
        }
    }

    protected String Navn
    {
        get
        {
            if (Session["Navn"] != null)
            {
                return (String)Session["Navn"];
            }
            else
            {
                return "Navnet ikke angitt";
            }
        }
        set
        {
            Session["Navn"] = value;
        }
    }
    protected String Farge
    {
        get
        {
            if (Session["Farge"] != null)
            {
                return (String)Session["Farge"];
            }
            else
            {
                return "Farge ikke angitt";
            }
        }
        set
        {
            Session["Farge"] = value;
        }
    }
}
