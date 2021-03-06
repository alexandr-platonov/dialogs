﻿using Newtonsoft.Json;

namespace Dialogs.Models.Alisa
{
    public class AlisaClientRequestViewModel<T>
    {
        [JsonProperty("request")]
        public RequestViewModel Request { get; set; }

        [JsonProperty("state")]
        public StateViewModel<T> State { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
