using System.Text.Json.Serialization;

namespace Dialogs.Models.Alisa
{
    public class ResponseViewModel
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("debug")]
        public object Debug { get; set; }
    }
}