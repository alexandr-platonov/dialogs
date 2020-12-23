using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class RequestViewModel
    {
        [JsonProperty("original_utterance")]
        public string OriginalUtterance { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("nlu")]
        public NluViewModel Nlu { get; set; }
    }
}