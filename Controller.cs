using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostFilestream
{
    public class FastController : ApiController
    {
        [Route("")]
        public HttpResponseMessage GetResult()
        {
            var fs = new FileStream(@"C:\data\SwissProt.xml", FileMode.Open,FileAccess.Read);
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StreamContent(fs)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/xml");
            //response.Content.Headers.ContentEncoding.Add("gzip");
            return response;
        }
    }

}
