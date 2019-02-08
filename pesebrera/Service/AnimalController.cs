using pesebrera.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace pesebrera.Service
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class AnimalController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<IAnimal> Get()
        {
            AnimalClassifier classifier = new AnimalClassifier();
            var animals = classifier.ExecuteClassification();
            return animals;
        }

        // GET api/<controller>/5
        public string Get(string name)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/<controller>/5
        public void Put(string name, [FromBody]IAnimal value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<controller>/5
        public void Delete(string name)
        {
            throw new NotImplementedException();
        }
    }
}