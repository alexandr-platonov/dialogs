using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class NluViewModel
    {
        [JsonProperty("tokens")]
        public string[] Tokens { get; set; }
    }
}