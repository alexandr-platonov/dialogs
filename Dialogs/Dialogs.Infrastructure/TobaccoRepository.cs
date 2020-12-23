using System.Collections.Generic;
using Dialogs.Domain.Interfaces.HookahMixer;
using Dialogs.Domain.Models.HookahMixer;

namespace Dialogs.Infrastructure
{
    public class TobaccoRepository : ITobaccoRepository
    {
        public List<HookahMix> GetHookahMixes()
        {
            //todo move to database
            return new List<HookahMix>
            {
                new HookahMix(
                    1,
                    "Яблоко и апельсин",
                    new TobaccoMix(new Tobacco(1, "Яблоко"), 50),
                    new TobaccoMix(new Tobacco(2, "Апельсин"), 50)
                ),
                new HookahMix(
                    2,
                    "Яблоко и кола",
                    new TobaccoMix(new Tobacco(1, "Яблоко"), 50),
                    new TobaccoMix(new Tobacco(3, "Кола"), 50)
                ),
            };
        }
    }
}
