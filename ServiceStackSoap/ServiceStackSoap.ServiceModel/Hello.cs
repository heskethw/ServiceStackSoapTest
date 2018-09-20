using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace ServiceStackSoap.ServiceModel
{
    [Route("/hello/{Id}")]
    public class Hello : IReturn<HelloResponse>
    {
        public int Id { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}