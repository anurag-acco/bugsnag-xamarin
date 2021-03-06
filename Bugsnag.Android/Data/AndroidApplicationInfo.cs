using Newtonsoft.Json;

namespace Bugsnag.Data
{
    internal class AndroidApplicationInfo : ApplicationInfo
    {
        [JsonProperty ("id")]
        public string Id { get; set; }

        [JsonProperty ("packageName")]
        public string Package { get; set; }

        [JsonProperty ("name")]
        public string Name { get; set; }
    }
}
