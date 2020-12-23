using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class AlisaClientResponseViewModel<T>
    {
        [JsonProperty("session")]
        public SessionViewModel Session { get; set; }

        [JsonProperty("response")]
        public ResponseViewModel Response { get; set; } 
        
        [JsonProperty("session_state")]
        public T SessionState { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}