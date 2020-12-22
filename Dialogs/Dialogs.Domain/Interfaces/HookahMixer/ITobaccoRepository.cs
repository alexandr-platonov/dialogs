using System.Collections.Generic;
using Dialogs.Domain.Models.HookahMixer;

namespace Dialogs.Domain.Interfaces.HookahMixer
{
    public interface ITobaccoRepository
    {
        public List<HookahMix> GetHookahMixes();
    }
}
