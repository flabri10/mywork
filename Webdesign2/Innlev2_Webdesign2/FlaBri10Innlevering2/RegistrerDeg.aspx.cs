using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class RegistrerDeg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnRegistrerDeg_Click(object sender, EventArgs e)
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
        {
            String brukernavn = txtBrukernavn.Text;

            Bruker nyBruker = new Bruker
            {
                Navn = txtNavn.Text,
                Brukernavn = txtBrukernavn.Text,
                Passord = txtPassord.Text,
                Profilbilde = fulProfilbilde.FileName
            };

            kobling.Brukers.InsertOnSubmit(nyBruker);
            kobling.SubmitChanges();
            kobling.Connection.Close();
        }
        Response.Redirect("Logginn.aspx");
    }
}