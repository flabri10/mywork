//Kodet av Britt-Heidi Fladby
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnleveringFlabri10.Models
{
    public class Anmeldelse
    {
        public Anmeldelse(int id, string epost, string tittel, string vurdering, string anmeldelsetekst)
        {
            Id = id;
            Epost = epost;
            Tittel = tittel;            
            Vurdering = vurdering;
            Anmeldelsetekst = anmeldelsetekst;
        }

        public int Id { get; set; }

        public string Epost { get; set; }

        public string Tittel { get; set; }

        public string Vurdering { get; set; }

        public string Anmeldelsetekst { get; set; }
    }
}
