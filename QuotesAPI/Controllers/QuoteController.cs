using QuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotesAPI.Controllers
{
    public class QuoteController : ApiController
    {
        static List<Quote> _quotes = new List<Quote>()
        {
            new Quote(){Id=0, Title = "Imagination", Author="Einstein", Description="Imagination is more important than knowledge"},
            new Quote() { Id = 1, Title = "Miles", Author = "Robert Frost", Description = "Miles to go before I sleep"},
        };
        public IEnumerable<Quote> Get() 
        {
            return _quotes;
        }

        public void Post([FromBody] Quote quote)
        {
            _quotes.Add(quote);
        }

        public void Put(int id, [FromBody] Quote quote) 
        {
            _quotes[id] = quote;
        }
        public void Delete(int id)
        {
            _quotes.RemoveAt(id);
        }

    }
}
