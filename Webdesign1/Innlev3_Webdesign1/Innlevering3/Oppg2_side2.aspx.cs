using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Oppg2_side2 : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblStatus2.Text = "Velkommen " + navn + "!";
            lblStatus2.ForeColor = Color.FromName(statusFarge);
        }
    }
}