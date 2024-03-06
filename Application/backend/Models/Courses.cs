using Newtonsoft.Json;

namespace backend.Models
{
    public class Courses
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

