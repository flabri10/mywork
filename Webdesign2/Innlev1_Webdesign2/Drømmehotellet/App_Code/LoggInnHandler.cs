using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

public class LoggInnHandler
{
    private String brukernavn;
    private String passord;

    public String Brukernavn
    {
        get 
        { 
            return brukernavn; 
        }
        set 
        { 
            brukernavn = value; 
        }
    }

    public String Passord
    {
        get 
        { 
            return passord; 
        }
        set 
        { 
            passord = value; 
        }
    }

    public LoggInnHandler()
    {
        brukernavn = "brukernavn";
        passord = "passord";
    }

    public bool SjekkOmRiktigLoggInn(string brukernavn, string passord)
    {
        if (Brukernavn == brukernavn && Passord == passord)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}