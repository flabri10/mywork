using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Oppg2_side1 : System.Web.UI.Page
{
    private String statusTekst;
    private String statusFarge;
    private String navn;
    private String status2;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RadioButtonFarger();
        VisStatus();
    }

    protected void SettRadioButtonFarger()
    {
        string[] fargeArray = new string[4];
        fargeArray[0] = "red";
        fargeArray[1] = "blue";
        fargeArray[2] = "yellow";
        fargeArray[3] = "green";

        for (int i = 0; i < fargeArray.Length; i++)
        {
            ListItem item = new ListItem (fargeArray[i]);
            rblListe.Items.Add(item);
        }

        rblListe.DataSource = statusFarge;
        rblListe.DataBind();

    }
    
    //knapper
    protected void btnLagreSession_Click(object sender, EventArgs e)
    {
        Session["Farge"] = statusFarge;
        Session["Navn"] = navn;
    }

    protected void btnTilSide2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Oppg2_side2.aspx");
    }

    protected void btnSlettSession_Click(object sender, EventArgs e)
    {
        Session["Navn"] = null;
    }
    
    protected void VisStatus()
    {
        String statusTekst;
        String statusFarge = (String)rblListe.SelectedItem.Text;
        String navn = txtNavn.Text;
        String status2 = ("Oppg2_side2.aspx")lblStatus2.Text;

        if (navn != null && statusFarge != null)
        {
            Navn = navn;
            Farge = statusFarge;
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
            if(Session["Navn"]!=null)
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
                rblListe.SelectedValue = Session["Farge"].ToString();
                statusFarge = rblListe.SelectedValue;
                return Session["Farge"].ToString();
            }
            else
            {
                return "Farge er ikke angitt";
            }
        }
        set
        {
            Session["Farge"] = value;
        }
    }

    protected void ColorSelector_IndexChanged(object sender, EventArgs e)
    {
        statusFarge = rblListe.SelectedValue;
        Session["Farge"] = rblListe.SelectedValue;
    }
}

   