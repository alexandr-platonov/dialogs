using System.Threading.Tasks;
using AutoMapper;
using Dialogs.Domain.Interfaces.HookahMixer;
using Dialogs.Domain.Models.Alisa;
using Dialogs.Domain.Models.HookahMixer;
using Dialogs.Models.Alisa;
using Microsoft.AspNetCore.Mvc;

namespace Dialogs.Controllers
{
    [ApiController]
    [Route("hookah-mixer")]
    public class HookahMixerController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHookahMixerClient _client;

        public HookahMixerController(IHookahMixerClient client, IMapper mapper)
        {
            _client = client;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Ask()
        {
            var alisaRequestViewModel = await ParseRequest<AlisaClientRequestViewModel<HookahMixViewModel>>().ConfigureAwait(false);

            var alisaRequest = _mapper.Map<AlisaClientRequest<HookahMix>>(alisaRequestViewModel);

            var result = await _client.Ask(alisaRequest).ConfigureAwait(false);

            var responseViewModel = _mapper.Map<AlisaClientResponseViewModel<HookahMixViewModel>>(result);

            return Ok(responseViewModel);
        }
    }
}
