using Microsoft.AspNetCore.Mvc;

namespace Dialogs.Controllers
{
    [ApiController]
    [Route("hookah-mixer")]
    public class HookahMixerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Ask()
        {
            return Ok();
        }
    }
}
