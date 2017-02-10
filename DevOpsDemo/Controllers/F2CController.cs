using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularJSWebApiEmpty.Models;


namespace AngularJSWebApiEmpty.Controllers
{
    public class F2CController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "Temperature Converter", "This is for converting temperature values (whole numbers only) from F to C!" };
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("api/f2c/{fValue}")]
        public result Get(int fValue)
        {
            // c/5 = (f-32)/9 => c = (f-32)*5/9
            result res = new result();
            res.ConvertedValue = ((fValue - 32) * 5 / 9);
            return res;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}