using System;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;


namespace Tabs
{
    public class csumcarapptable



    {

        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "make")]
        public string make { get; set; }

        [JsonProperty(PropertyName = "model")]
        public string model { get; set; }

        [JsonProperty(PropertyName = "engine")]
        public string engine { get; set; }

		[JsonProperty(PropertyName = "detail")]
		public string detail { get; set; }



    }
}