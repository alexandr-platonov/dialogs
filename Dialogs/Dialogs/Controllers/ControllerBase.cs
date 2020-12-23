using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dialogs.Controllers
{
    public class ControllerBase : Controller
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter
                {
                    DateTimeStyles = DateTimeStyles.AssumeUniversal
                }
            },
        };

        public async Task<T> ParseRequest<T>()
        {
            string requestBody = await new StreamReader(Request.Body).ReadToEndAsync();
            var mappedRequest = JsonConvert.DeserializeObject<T>(requestBody, Settings);

            return mappedRequest;
        }
    }
}