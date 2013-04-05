//Kodet av Britt-Heidi Fladby
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnleveringFlabri10.Models
{
    public class EpostSoek
    {

        public EpostSoek(string soekEpost)
        {
            SoekEpost = soekEpost;
        }

        public string SoekEpost { get; set; }
    }
}
