namespace Dialogs.Infrastructure.Models
{
    public class SearchFilmsResponseDto
    {
        public bool Response { get; set; }
        public string Error { get; set; }
        public int TotalResults { get; set; }
        public SearchFilmDto[] Search { get; set; }
    }
}