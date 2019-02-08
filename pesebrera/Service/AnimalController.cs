using pesebrera.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace pesebrera.Service
{
    public class AnimalController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            AnimalClassifier classifier = new AnimalClassifier();
            var animals = classifier.ExecuteClassification();
            return null;
        }

        // GET api/<controller>/5
        public string Get(string name)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(string name, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(string name)
        {
        }
    }
}