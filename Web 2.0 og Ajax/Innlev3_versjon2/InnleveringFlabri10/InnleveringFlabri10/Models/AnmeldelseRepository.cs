//Kodet av Britt-Heidi Fladby
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Web;
using System.Text;

namespace InnleveringFlabri10.Models
{
    public class AnmeldelseRepository
    {
        private static List<Anmeldelse> filmliste = new List<Anmeldelse>();
        public string txtSoekEpost;
        public string soekEpost;
        public static XElement xmlFilmliste;

        static AnmeldelseRepository()
        {
            try
            {
                HentFil(xmlFilmliste);
                var filmliste = from filmanmeldelser in xmlFilmliste.Descendants("filmanmeldelse") select filmanmeldelser;

                foreach (var anmeldelse in filmliste)
                {
                    var film = new Anmeldelse(
                        Convert.ToInt32(anmeldelse.Element("id").Value),
                        anmeldelse.Element("tittel").Value,
                        anmeldelse.Element("epost").Value,
                        anmeldelse.Element("vurdering").Value,
                        anmeldelse.Element("anmeldelsetekst").Value);

                    xmlFilmliste.Add(film);
                }
                xmlFilmliste.Save("xmlFilmanmeldelseliste.xml");
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Feil ved oppretting av xml.");
            }
        }

        public List<Anmeldelse> Anmeldelser { get { return filmliste; } }

        public static String HentFil(XElement xmlFilmliste)
        {
            try
            {
                xmlFilmliste = XElement.Load("xmlFilmanmeldelseliste.xml");
                return xmlFilmliste.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Feil ved filhenting.");
                return null;
            }
        }

        protected void FyllAnmeldelseliste()
        {
            try
            {
                HentFil(xmlFilmliste);
                var filmliste = from filmanmeldelser in xmlFilmliste.Descendants("filmanmeldelse") select filmanmeldelser;
                
                StringBuilder sbFilmliste = new StringBuilder();

                foreach (var filmanmeldelse in filmliste)
                {
                    sbFilmliste.AppendFormat("<article class='modul'><h3>{0}</h3><p><i>Id: {1}</i></br><i>Skrevet av: {2}</i></br>Terningkast: {3}</br>Anmeldelse: {4}</p></article>",
                            (String)filmanmeldelse.Element("tittel"),
                            (String)filmanmeldelse.Element("id"),
                            (String)filmanmeldelse.Element("epost"),
                            (String)filmanmeldelse.Element("vurdering"),
                            (String)filmanmeldelse.Element("anmeldelse")
                        );
                }

                Console.WriteLine(sbFilmliste);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Feil ved fylling av liste.");
            }
        }

        public string hentTxtSoekEpost(string txtSoekEpost)
        {
            return txtSoekEpost;
        }

        protected XElement HentAnmeldelseEtterEpost(String soekEpost)
        {
            try
            {
                soekEpost = hentTxtSoekEpost(txtSoekEpost);
                HentFil(xmlFilmliste);

                var valgtAnmeldelse = (from filmanmeldelse in xmlFilmliste.Descendants("filmanmeldelse")
                                       where (String)filmanmeldelse.Element("epost") == soekEpost
                                       select filmanmeldelse).SingleOrDefault();
                return valgtAnmeldelse;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Feil ved anmeldelsehenting etter epost.");
                return null;
            }
        }

        protected void HentAnmeldelse(object sender, EventArgs e)
        {
            try
            {
                var valgtAnmeldelse = HentAnmeldelseEtterEpost(soekEpost);
                StringBuilder sbFilmliste = new StringBuilder();

                Console.WriteLine("Resultat fra epostsøk: " + (String)valgtAnmeldelse.Element("epost"));

                if (valgtAnmeldelse != null)
                {
                    sbFilmliste.AppendFormat("<article class='modul'><h3>{0}</h3><p><i>Id: {1}</i></br><i>Skrevet av: {2}</i></br>Terningkast: {3}</br>Anmeldelse: {4}</p></article>",
                            (String)valgtAnmeldelse.Element("tittel"),
                            (String)valgtAnmeldelse.Element("id"),
                            (String)valgtAnmeldelse.Element("epost"),
                            (String)valgtAnmeldelse.Element("vurdering"),
                            (String)valgtAnmeldelse.Element("anmeldelse")
                    );

                    Console.WriteLine(sbFilmliste);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Feil ved henting av anmeldelse.");
            }

        }
    }
}
