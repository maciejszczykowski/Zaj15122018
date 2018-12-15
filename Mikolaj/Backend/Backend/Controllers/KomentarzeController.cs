using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Backend.Models;
using System.Web.Http.Cors; //dla akceptowania żądan przez witryny o innym adresie
namespace Backend.Controllers
{

      [EnableCors(origins: "*", headers: "*", methods: "*")] //każdej stronie pozwalamy sie laczyc metodami kazdymi czyli i get i post
    public class KomentarzeController : ApiController
    {
        // GET api/komentarze
        public IEnumerable<Comment> Get()
        {
            var db = new MikolajEntities(); //uchwyt do bazy danych
            return db.Comments.ToArray(); //zwroci jako tablice komentarzy Array
        }

        // GET api/komentarze/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/komentarze
        public void Post([FromBody]string value)
        {
        }

        // PUT api/komentarze/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/komentarze/5
        public void Delete(int id)
        {
        }
    }
}
