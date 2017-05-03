using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace readify.Controllers
{
    public class ReverseWordsController : ApiController
    {
        
        // GET api/<controller>/5
        public string Get(string sentence)
        {
            var reversedWords = string.Join(" ",
                sentence.Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));
            return reversedWords;
        }

    }
}