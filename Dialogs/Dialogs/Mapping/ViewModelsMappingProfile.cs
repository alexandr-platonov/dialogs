using System.Collections.Generic;
using AutoMapper;
using Dialogs.Domain.Models.Alisa;
using Dialogs.Domain.Models.HookahMixer;
using Dialogs.Domain.Models.KinoRating;
using Dialogs.Models.Alisa;

namespace Dialogs.Mapping
{
    public class ViewModelsMappingProfile : Profile
    {
        public ViewModelsMappingProfile()
        {
            CreateMap<AlisaClientRequestViewModel<HookahMix>, AlisaClientRequest<HookahMix>>();
            CreateMap<AlisaClientRequestViewModel<List<SearchFilm>>, AlisaClientRequest<List<SearchFilm>>>();
            CreateMap<RequestViewModel, Request>();
            CreateMap<StateViewModel<HookahMix>, State<HookahMix>>();
            CreateMap<StateViewModel<List<SearchFilm>>, State<List<SearchFilm>>>();
            CreateMap<AlisaSaveDataViewModel<HookahMix>, AlisaSaveData<HookahMix>>();
            CreateMap<AlisaSaveDataViewModel<List<SearchFilm>>, AlisaSaveData<List<SearchFilm>>>();
            CreateMap<AlisaClientResponse<HookahMix>, AlisaClientResponseViewModel<HookahMix>>();
            CreateMap<AlisaClientResponse<List<SearchFilm>>, AlisaClientResponseViewModel<List<SearchFilm>>>();
            CreateMap<AlisaSaveData<HookahMix>, AlisaSaveDataViewModel<HookahMix>>();
            CreateMap<AlisaSaveData<List<SearchFilm>>, AlisaSaveDataViewModel<List<SearchFilm>>>();
            CreateMap<Response, ResponseViewModel>();
        }
    }
}