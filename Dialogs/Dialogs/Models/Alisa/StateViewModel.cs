using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class StateViewModel<T>
    {
        [JsonProperty("session")]
        public T Session { get; set; }
    }
}