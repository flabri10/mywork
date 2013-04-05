using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LoggInnHandler
/// </summary>
public class LoggInnHandler
{
	public LoggInnHandler()
	{

	}

    public bool sjekkAdminLoggInn(String brukernavn, String passord)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Administrator> administratorListe = (from administrator in kobling.Administrators select administrator).ToList();

            foreach (Administrator administrator in administratorListe)
            {
                if (brukernavn == administrator.Brukernavn)
                {
                    if (passord == administrator.Passord)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }

    public bool sjekkBrukerLoggInn(String brukernavn, String passord)
    {
        using (ormRomskipetDataContext kobling = new ormRomskipetDataContext())
        {
            List<Bruker> brukerListe = (from bruker in kobling.Brukers select bruker).ToList();

            foreach (Bruker bruker in brukerListe)
            {
                if (brukernavn == bruker.Brukernavn)
                {
                    if (passord == bruker.Passord)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


    }
}