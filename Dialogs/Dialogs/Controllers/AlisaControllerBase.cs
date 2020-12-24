using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Dialogs.Domain.Interfaces.Alisa;
using Dialogs.Domain.Models.Alisa;
using Dialogs.Models.Alisa;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dialogs.Controllers
{
    public class AlisaControllerBase<T> : Controller
    {
        private readonly IAlisaClient<T> _client;
        private readonly IMapper _mapper;

        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings
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

        public AlisaControllerBase(IAlisaClient<T> client, IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Ask()
        {
            try
            {
                string requestBody = await new StreamReader(Request.Body).ReadToEndAsync();

                var alisaRequestViewModel = JsonConvert.DeserializeObject<AlisaClientRequestViewModel<T>>(requestBody, _settings);

                var alisaRequest = _mapper.Map<AlisaClientRequest<T>>(alisaRequestViewModel);

                var result = await _client.Ask(alisaRequest).ConfigureAwait(false);

                var responseViewModel = _mapper.Map<AlisaClientResponseViewModel<T>>(result);

                return Ok(responseViewModel);
            }
            catch (Exception exception)
            {
                var model = new AlisaClientResponseViewModel<T>
                {
                    Version = "1.0",
                    Response = new ResponseViewModel
                    {
                        Text = "Что-то пошло не так",
                        Debug = exception
                    }
                };

                return Ok(model);
            }
        }
    }
}