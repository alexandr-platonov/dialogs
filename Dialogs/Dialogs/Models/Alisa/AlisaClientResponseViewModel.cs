using System.Text.Json.Serialization;

namespace Dialogs.Models.Alisa
{
    public class AlisaClientResponseViewModel<T>
    {
        [JsonPropertyName("response")]
        public ResponseViewModel Response { get; set; }

        [JsonPropertyName("session_state")]
        public AlisaSaveDataViewModel<T> SessionState { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}