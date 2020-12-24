using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class StateViewModel<T>
    {
        [JsonProperty("session")]
        public AlisaSaveDataViewModel<T> Session { get; set; }
    }
}