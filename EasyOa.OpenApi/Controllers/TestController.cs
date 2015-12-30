using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyOa.Common;

namespace EasyOa.OpenApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public dynamic M1()
        {
            var pub8 =
                "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDJCetveWeCbC6EoPxAeJee9gvW4kaomKWpPtJiNBb5zX+w+pzx/G5I8EA2IcDHm/nMcUV+lmSzS3k6EuKGwYtKb7CAcLQxtG0j0Wzg6mmyFZ5kvRrz5WUEiquNwrshGZ7Bp6zoVDryL9bkfNuFfTrY0qCHj11ojcWDCyt+fssJRQIDAQAB";
            var pri8 =
                "MIICeAIBADANBgkqhkiG9w0BAQEFAASCAmIwggJeAgEAAoGBAMkJ6295Z4JsLoSg/EB4l572C9biRqiYpak+0mI0FvnNf7D6nPH8bkjwQDYhwMeb+cxxRX6WZLNLeToS4obBi0pvsIBwtDG0bSPRbODqabIVnmS9GvPlZQSKq43CuyEZnsGnrOhUOvIv1uR824V9OtjSoIePXWiNxYMLK35+ywlFAgMBAAECgYEAj4GzPEnPZ7xNoINCTctHgENmxCeWBLeiWaPsjglc9UiKBA2BhwOIviwxyfJiKJrgv92DnA9DJvGTQa9FYKg8Asq543dB8QC9KbOWgFzpqQf1lTzmsb7bATcQ+q1hpxKCWSroqg3/0tTCxWDpp/onaH3Hg4yUh0YDAuiRAbq5wmkCQQD9t/LGJqo5vQCIkWVjHsLcs6htc/sOBLXwGGIFn8SySkND90RA8UthNdGEuMirYV/nA7ukBZchnQiUtGjNGOcLAkEAyti0RY+0qjUnRnLPjTxCI5gLU7DqvIlWTupShgs8xgNXyCLWs05gATdfXN+AWmJOcFAlUszCcpeD2CqG9X/C7wJBAM2Q+5+2dhdf3g3Il/fuVX2SBrXf0ZpzEKIeb1UVNL4r00I/Fkrz9domS8KYIOZSd+xppt9nNCMk423wmjUKpy8CQEjQMx3JMPvsKpYCPnifScqHGIHJPunAjsezGz5cqEsYBhmkT9d7acDmBIhM/kDzit6MFmm7cI070Cr3UQys+OcCQQDZ9Nofh7oDzZY6te8/zLwvsABMz1u0vGYovjADPDZThplS+ZsSeTtJaVzPE5FPW3IVZhTdnb2sOger4trXQCZx";

            
            var s1 = AsymmetricEncryptHelper.RSAEncode("123456", pub8);
            var s2 = AsymmetricEncryptHelper.RSADecode(s1,pri8);
            return s2;
        }
    }
}
