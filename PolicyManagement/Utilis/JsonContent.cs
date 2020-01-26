using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PolicyManagement.Utilis
{
    public class JsonContent : HttpContent
    {
        private readonly JToken jToken;

        public JsonContent(string json)
        {
            jToken = JObject.Parse(json);
        }

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
        {
            var jw = new JsonTextWriter(new StreamWriter(stream))
            {
                Formatting = Formatting.Indented
            };
            jToken.WriteTo(jw);
            jw.Flush();
            return Task.FromResult<object>(null);
        }

        protected override bool TryComputeLength(out long length)
        {
            length = -1;
            return false;
        }
    }
}