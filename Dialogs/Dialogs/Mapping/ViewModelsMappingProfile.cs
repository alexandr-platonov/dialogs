using AutoMapper;
using Dialogs.Domain.Models.Alisa;
using Dialogs.Domain.Models.HookahMixer;
using Dialogs.Models.Alisa;

namespace Dialogs.Mapping
{
    public class ViewModelsMappingProfile : Profile
    {
        public ViewModelsMappingProfile()
        {
            CreateMap<AlisaClientRequestViewModel<HookahMixViewModel>, AlisaClientRequest<HookahMix>>();
            CreateMap<SessionViewModel, Session>();
            CreateMap<RequestViewModel, Request>();
            CreateMap<NluViewModel, Nlu>();
            CreateMap<StateViewModel<HookahMixViewModel>, State<HookahMix>>();
            CreateMap<HookahMixViewModel, HookahMix>();
            CreateMap<TobaccoMixViewModel, TobaccoMix>();
            CreateMap<TobaccoViewModel, Tobacco>();

            CreateMap<AlisaClientResponse<HookahMix>, AlisaClientResponseViewModel<HookahMixViewModel>>();
            CreateMap<Session, SessionViewModel>();
            CreateMap<Response, ResponseViewModel>();
            CreateMap<HookahMix, HookahMixViewModel>();
            CreateMap<TobaccoMix, TobaccoMixViewModel>();
            CreateMap<Tobacco, TobaccoViewModel>();
        }
    }
}
