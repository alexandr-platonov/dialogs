using System.Collections.Generic;
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
            CreateMap<AlisaClientRequestViewModel<HookahMix>, AlisaClientRequest<HookahMix>>();
            CreateMap<RequestViewModel, Request>();
            CreateMap<StateViewModel<HookahMix>, State<HookahMix>>();
            CreateMap<AlisaSaveDataViewModel<HookahMix>, AlisaSaveData<HookahMix>>();
            CreateMap<AlisaClientResponse<HookahMix>, AlisaClientResponseViewModel<HookahMix>>();
            CreateMap<AlisaSaveData<HookahMix>, AlisaSaveDataViewModel<HookahMix>>();
            CreateMap<Response, ResponseViewModel>();
        }
    }
}
