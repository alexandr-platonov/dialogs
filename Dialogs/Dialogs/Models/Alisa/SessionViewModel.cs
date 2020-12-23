using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class SessionViewModel
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
 