using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace PolicyManagement.Utilis
{
    public class OkJsonPathResult: OkResult
    {
        private readonly MediaTypeWithQualityHeaderValue acceptJson = new MediaTypeWithQualityHeaderValue("application/json");

        public OkJsonPathResult(ApiController controller) : base(controller)
        {

        }

        public override Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var accept = Request.Headers.Accept;
            var jsonFormat = accept.Any(h => h.Equals(acceptJson));

            if (jsonFormat)
            {
                return Task.FromResult(ExcecuteResult());
            }
            else
            {
                return base.ExecuteAsync(cancellationToken);
            }
        }

        private HttpResponseMessage ExcecuteResult()
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new JsonContent("{}"),
                RequestMessage = Request
            };
        }
    }
}