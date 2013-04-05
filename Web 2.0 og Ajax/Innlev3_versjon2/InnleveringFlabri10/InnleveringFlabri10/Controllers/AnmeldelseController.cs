//Kodet av Britt-Heidi Fladby
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using InnleveringFlabri10.Models;

namespace InnleveringFlabri10.Controllers
{
    public class AnmeldelseController : ApiController
    {
        public IEnumerable<Anmeldelse> Get()
        {
            var repository = new AnmeldelseRepository();

            return repository.Anmeldelser.OrderBy(c => c.Id);
        }

        public Anmeldelse Get(int id)
        {
            var repository = new AnmeldelseRepository();

            return repository.Anmeldelser.Find(c => c.Id == id);
        }

        public void Post([FromBody]string value)
        { 
        
        }

        public void put(int id, Anmeldelse value)
        {
            var repository = new AnmeldelseRepository();
            var toBeRemoved = Get(id);

            repository.Anmeldelser.Remove(toBeRemoved);
            repository.Anmeldelser.Add(value);
        }

        public void Delete(int id)
        { 
        
        }
    }
}
