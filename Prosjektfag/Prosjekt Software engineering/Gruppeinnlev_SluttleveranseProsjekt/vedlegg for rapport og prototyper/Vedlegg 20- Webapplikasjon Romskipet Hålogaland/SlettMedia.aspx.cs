using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SlettMedia : System.Web.UI.Page
{
    String id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Request.Params.Get("BildeID");
        SlettBilde();
    }

    protected void SlettBilde()
    {
        try
        {
            using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
            {
                Bilder valgtBilde = (from bilde in kobling.Bilders where bilde.BildeID == Convert.ToInt32(id) select bilde).SingleOrDefault();

                kobling.Bilders.DeleteOnSubmit(valgtBilde);
                kobling.SubmitChanges();
                Response.Redirect("AdminPanel.aspx");
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("AdminPanel.aspx");
        }
    }
}