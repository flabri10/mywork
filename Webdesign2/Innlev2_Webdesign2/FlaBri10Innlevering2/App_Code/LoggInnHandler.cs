using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class LoggInnHandler
{
    public LoggInnHandler()
    {

    }

    public bool sjekkBrukerLoggInn(String brukernavn, String passord)
    {
        using (ormMinKunstDataContext kobling = new ormMinKunstDataContext())
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