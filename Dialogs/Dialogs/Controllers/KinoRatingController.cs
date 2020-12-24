using System.Collections.Generic;
using AutoMapper;
using Dialogs.Domain.Interfaces.KinoRating;
using Dialogs.Domain.Models.KinoRating;
using Microsoft.AspNetCore.Mvc;

namespace Dialogs.Controllers
{
    [ApiController]
    [Route("kino-rating")]
    public class KinoRatingController : AlisaControllerBase<List<SearchFilm>>
    {
        public KinoRatingController(IKinoRatingClient client, IMapper mapper) : base(client, mapper)
        {
        }
    }
}