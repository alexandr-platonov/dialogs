namespace Dialogs.Domain.Models.KinoRating
{
    public class KinoRatingResponse
    {
        public KinoRatingResponse(Film result)
        {
            IsSuccess = true;
            Error = null;
            Result = result;
        }

        public bool IsSuccess { get; }
        public string Error { get; }
        public Film Result { get; }
    }
}