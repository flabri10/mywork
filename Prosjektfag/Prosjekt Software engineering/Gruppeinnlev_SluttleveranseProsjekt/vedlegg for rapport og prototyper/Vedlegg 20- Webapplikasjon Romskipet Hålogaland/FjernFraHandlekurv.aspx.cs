using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class FjernFraHandlekurv : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = Request.Params.Get("ProduktID");
        FjernOrdre(id);
        Response.Redirect("Handlekurv.aspx");
    }

    protected void FjernOrdre(String id)
    {
        ArrayList handleKurv = (ArrayList)Session["Handlekurv"];
        int i = 0;

        foreach (String[] ordre in handleKurv)
        {
            if (ordre[0] == id)
            {
                handleKurv.RemoveAt(i);
                return;
            }
            i++;
        }
    }
}