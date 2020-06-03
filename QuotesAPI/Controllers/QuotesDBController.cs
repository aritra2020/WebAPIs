using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuotesAPI.Models;
using QuotesAPI.Data;

namespace QuotesAPI.Controllers
{
    public class QuotesDBController : ApiController
    {
        QuotesDBContext quotesDBContext = new QuotesDBContext();
        // GET: api/QuotesDB
        public IEnumerable<Quote> Get()
        {
            return quotesDBContext.Quotes;
        }

        // GET: api/QuotesDB/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/QuotesDB
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/QuotesDB/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/QuotesDB/5
        public void Delete(int id)
        {
        }
    }
}
