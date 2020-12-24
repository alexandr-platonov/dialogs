using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class RequestViewModel
    {
        [JsonProperty("command")]
        public string Command { get; set; }
    }
}