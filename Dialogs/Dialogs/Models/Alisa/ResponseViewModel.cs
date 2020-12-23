using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class ResponseViewModel
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("debug")]
        public string Debug { get; set; }

        [JsonProperty("end_session")]
        public bool EndSession { get; set; }
    }
}