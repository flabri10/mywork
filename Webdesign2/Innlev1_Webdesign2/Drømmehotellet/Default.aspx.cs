using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Xml;

public partial class how_to_login_with_xml_c : System.Web.UI.Page
{
    protected void Login1_Authenticate(object sender, System.Web.UI.WebControls.AuthenticateEventArgs e)
    {
        string username;
        string pwd;
        string CurrentUser = "";
        string CurrentPwd = "";
        bool LoginStatus = false;

        username = Login1.UserName;
        pwd = Login1.Password;

        XmlDocument xd = new XmlDocument();
        xd.Load(Server.MapPath("~/App_Data/AllUser.xml"));

        XmlNodeList xnl = xd.GetElementsByTagName("User");

        foreach (XmlNode xn in xnl)
        {
            XmlNodeList cxnl = xn.ChildNodes;
            foreach (XmlNode cxn in cxnl)
            {
                if (cxn.Name == "username")
                {
                    if (cxn.InnerText == username)
                    {
                        CurrentUser = username;
                    }
                }

                if (cxn.Name == "password")
                {
                    if (cxn.InnerText == pwd)
                    {
                        CurrentPwd = pwd;
                    }
                }
            }

            if ((CurrentUser != "") & (CurrentPwd != ""))
            {
                LoginStatus = true;
            }
        }

        if (LoginStatus == true)
        {
            Session["UserAuthentication"] = username;
            Session.Timeout = 1;

            Response.Redirect("how-to-StartPage.aspx");
        }
        else
        {
            Session["UserAuthentication"] = "";
        }
    }
}

