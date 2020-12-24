using Dialogs.Domain.Interfaces.HookahMixer;
using Dialogs.Domain.Models.HookahMixer;
using Dialogs.Domain.Services.Alisa;

namespace Dialogs.Domain.Services.HookahMixer
{
    public class HookahMixerClient: AlisaClient<HookahMix, IHookahMixerDialog>, IHookahMixerClient
    {
        public HookahMixerClient(IHookahMixerDialog dialog) : base(dialog)
        {
        }
    }
}