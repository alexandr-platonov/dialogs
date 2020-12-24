using System;
using System.Linq;
using System.Threading.Tasks;
using Dialogs.Domain.Interfaces.HookahMixer;
using Dialogs.Domain.Models;
using Dialogs.Domain.Models.HookahMixer;

namespace Dialogs.Domain.Services.HookahMixer
{
    public class HookahMixerDialog : IHookahMixerDialog
    {
        private readonly ITobaccoRepository _tobaccoRepository;

        public HookahMixerDialog(ITobaccoRepository tobaccoRepository)
        {
            _tobaccoRepository = tobaccoRepository;
        }

        public Task<TextDialogResponse<HookahMix>> Ask(TextDialogRequest<HookahMix> request)
        {
            if (string.IsNullOrEmpty(request.Command))
            {
                return Task.FromResult(new TextDialogResponse<HookahMix>("Какие вкусы у вас есть?"));
            }

            var words = request.Command.Split(' ');

            var mixes = _tobaccoRepository.GetHookahMixes();

            var suitableMixes = _tobaccoRepository.GetHookahMixes()
                .ToDictionary(x => x.Id, x =>
                {
                    var tobaccos = x.Tobaccos.Select(t => t.Tobacco.Name);
                    var intersect = words.Intersect(tobaccos, new Tobacco.EqualityComparer());
                    var count = intersect.Count();

                    return count;
                });

            var random = new Random();

            var maxSuitableValue = suitableMixes.Max(x => x.Value);
            var maxSuitableMixes = suitableMixes.Where(x => x.Value == maxSuitableValue).OrderBy(x => random.Next());
            var suitableMixId = maxSuitableMixes.First().Key;
            var suitableMix = mixes.Single(x => x.Id == suitableMixId);

            return Task.FromResult(new TextDialogResponse<HookahMix>(suitableMix, $"Попробуй {suitableMix.Description}"));
        }
    }
}