using AutoMapper;
using Dialogs.Domain.Interfaces.HookahMixer;
using Dialogs.Domain.Models.HookahMixer;
using Microsoft.AspNetCore.Mvc;

namespace Dialogs.Controllers
{
    [ApiController]
    [Route("hookah-mixer")]
    public class HookahMixerController : AlisaControllerBase<HookahMix>
    {
        public HookahMixerController(IHookahMixerClient client, IMapper mapper) : base(client, mapper)
        {
        }
    }
}
