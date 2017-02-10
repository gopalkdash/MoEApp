using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSWebApiEmpty.Models;
using AngularJSWebApiEmpty.Converters;

namespace AngularJSWebApiEmpty.Controllers
{
    public class C2FController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Temperature Converter", "This is for converting temperature values (whole numbers only) from C to F!" };
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("api/c2f/{cValue}")]
        public result Get(int cValue)
        {
            // c/5 = (f-32)/9 => c = (f-32)*5/9
            result res = new result();
            C2FConverter c2f = new C2FConverter();
            res.ConvertedValue = c2f.C2F(cValue);
            return res;
        }


    }
}
