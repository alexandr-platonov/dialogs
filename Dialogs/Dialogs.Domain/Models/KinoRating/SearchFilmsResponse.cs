using System.Collections.Generic;

namespace Dialogs.Domain.Models.KinoRating
{
    public class SearchFilmsResponse
    {
        public SearchFilmsResponse(string error)
        {
            IsSuccess = false;
            Error = error;
            Result = null;
        }

        public SearchFilmsResponse(List<SearchFilm> result)
        {
            IsSuccess = true;
            Error = null;
            Result = result;
        }

        public bool IsSuccess { get; }
        public string Error { get; }
        public List<SearchFilm> Result { get; }
    }
}